using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetHavenManagementSystem
{
    public partial class AdminDashboard : Form
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public AdminDashboard()
        {
            InitializeComponent();
 
        }

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

        private void UpdateGreetingAndClock()
        {
            DateTime now = DateTime.Now;

            
            lblClock.Text = now.ToString("hh:mm:ss tt");

           
            string greeting;
            int hour = now.Hour;

            if (hour >= 5 && hour < 12)
                greeting = "Good Morning, Admin!";
            else if (hour >= 12 && hour < 17)
                greeting = "Good Afternoon, Admin!";
            else if (hour >= 17 && hour < 21)
                greeting = "Good Evening, Admin!";
            else
                greeting = "Good Night, Admin!";

            lblGreeting.Text = greeting;
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
        private void LoadNewOwners()
        {
            string query = @"
                SELECT OwnerID, FullName, ContactNumber, Email, DateRegistered
                FROM Owners
                WHERE DateRegistered >= DATEADD(DAY, -30, GETDATE())
                ORDER BY DateRegistered DESC;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;

                
                if (dataGridView1.Columns.Contains("OwnerID"))
                    dataGridView1.Columns["OwnerID"].Visible = false;
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        { 
            timer1.Start();
            UpdateGreetingAndClock();

            lblOwnerscount.Text = $"{GetUserCount("Owners")}";
            lblAppointmentscount.Text = $"{GetUserCount("Appointments")}";
            lblMemberships.Text = $"{GetUserCount("Memberships")}";
            lblDoctorscount.Text = $"{GetUserCount("Vets")}";
            LoadSpeciesDoughnutChart();
            LoadAppointmentChart();
            LoadRecentAppointments();
            LoadNewOwners();
        }
        private void LoadRecentAppointments()
        {
            string query = @"
                SELECT TOP 10 
                    a.AppointmentId,
                    p.PetName,
                    o.FullName,
                    v.FullName,
                    a.AppointmentDate,
                    a.Status
                FROM Appointments a
                JOIN Pets p ON a.PetId = p.PetID
                JOIN Owners o ON a.OwnerId = o.OwnerID
                JOIN Vets v ON a.VetId = v.VetID
                ORDER BY a.AppointmentDate DESC;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                if (dataGridView2.Columns.Contains("AppointmentId"))
                    dataGridView2.Columns["AppointmentId"].Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            UpdateGreetingAndClock();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chartSpeciesDoughnut_Click(object sender, EventArgs e)
        {

        }

        private void chartAppointments_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDoctorscount_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAppointmentscount_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOwnerscount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMemberships_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
