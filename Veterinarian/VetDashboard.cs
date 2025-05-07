using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetHavenManagementSystem
{
    public partial class VetDashboard : Form
    {
        public VetDashboard()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private int GetUserCount(string table)
        {
            string query = $"SELECT COUNT(*) FROM {table}";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        private void LoadAppointmentChart()
        {
            chartAppointments.ChartAreas[0].AxisX.Title = "Month";
            chartAppointments.ChartAreas[0].AxisY.Title = "Number of Appointments";
            chartAppointments.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartAppointments.Series.Clear(); 

            Series series = new Series("Appointments");
            series.ChartType = SeriesChartType.Area; 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT FORMAT(AppointmentDate, 'yyyy-MM') AS Month, COUNT(*) AS Total
            FROM Appointments
            GROUP BY FORMAT(AppointmentDate, 'yyyy-MM')
            ORDER BY Month";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string month = reader.GetString(0);
                        int total = reader.GetInt32(1);
                        series.Points.AddXY(month, total);
                    }
                }
            }

            chartAppointments.Series.Add(series);
        }
        private void LoadSpeciesDoughnutChart()
        {
            chartSpeciesDoughnut.Series.Clear();

            Series series = new Series("Species");
            series.ChartType = SeriesChartType.Doughnut;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT p.Species, COUNT(*) AS TotalAppointments
            FROM Appointments a
            JOIN Pets p ON a.PetId = p.PetId
            GROUP BY p.Species";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string species = reader.GetString(0);
                        int count = reader.GetInt32(1);
                        series.Points.AddXY(species, count);
                    }
                }
            }

            chartSpeciesDoughnut.Series.Add(series);

            
            series.IsValueShownAsLabel = true;

            
            chartSpeciesDoughnut.Palette = ChartColorPalette.Berry;

           
            chartSpeciesDoughnut.Legends[0].Enabled = true;
            chartSpeciesDoughnut.Legends[0].Docking = Docking.Right;
        }

        private void gunaElipsePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VetDashboard_Load(object sender, EventArgs e)
        {
            lblOwnerCount.Text = $"{GetUserCount("Owners")}";
            lblAppointments.Text = $"{ GetUserCount("Appointments")}";
            lblMemberships.Text = $"{GetUserCount("Memberships")}";
            LoadAppointmentChart();
            LoadSpeciesDoughnutChart();
        }

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
