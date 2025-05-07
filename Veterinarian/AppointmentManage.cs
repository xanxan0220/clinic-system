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
using PetHavenManagementSystem.Models;

namespace PetHavenManagementSystem
{
    public partial class AppointmentManage : Form
    {
        public AppointmentManage()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private void LoadAppointmentsForVet()
        {
            int vetId = SessionManager.LoggedInUserID;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT a.AppointmentId, o.FullName, p.PetName, a.AppointmentDate,a.AppointmentTime,a.Notes, a.Status
                    FROM Appointments a
                    INNER JOIN Owners o ON a.OwnerID = o.OwnerID
                    INNER JOIN Pets p ON a.PetID = p.PetID
                    WHERE a.VetID = @VetID
                    ORDER BY a.AppointmentDate, a.AppointmentTime";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@VetId", vetId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;  
                }
            }
            catch (SqlException sqlEx)
            {
                
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentManage_Load(object sender, EventArgs e)
        {
            LoadAppointmentsForVet();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AppointmentId"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Appointments SET Status = 'Accepted' WHERE AppointmentId = @AppointmentId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment accepted!");
                LoadAppointmentsForVet(); // Reload updated list
            }
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to reject this appointment?",
                    "Confirm Rejection",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int appointmentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AppointmentId"].Value);

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = "UPDATE Appointments SET Status = 'Rejected' WHERE AppointmentId = @AppointmentId";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Appointment rejected successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointmentsForVet(); // Refresh the grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while rejecting the appointment:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to reject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
