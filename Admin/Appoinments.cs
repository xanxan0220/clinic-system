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

namespace PetHavenManagementSystem
{
    public partial class Appoinments : Form
    {
        public Appoinments()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private void LoadAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                        SELECT 
                            A.AppointmentId,
                            A.AppointmentDate,
                            A.AppointmentTime,
                            A.Notes,
                            A.Status,
                            O.FullName AS OwnerName,
                            P.PetName AS PetName,
                            V.FullName AS VetName
                        FROM Appointments A
                        JOIN Owners O ON A.OwnerId = O.OwnerID
                        JOIN Pets P ON A.PetId = P.PetID
                        JOIN Vets V ON A.VetId = V.VetID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

              
                dataGridView1.Columns["AppointmentId"].Visible = false;
                dataGridView1.Columns["OwnerName"].HeaderText = "Owner";
                dataGridView1.Columns["PetName"].HeaderText = "Pet";
                dataGridView1.Columns["VetName"].HeaderText = "Veterinarian";
                dataGridView1.Columns["AppointmentDate"].HeaderText = "Date";
                dataGridView1.Columns["AppointmentTime"].HeaderText = "Time";
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT * FROM Appointments
            WHERE 
                CAST(AppointmentId AS NVARCHAR) LIKE @keyword OR
                CAST(OwnerId AS NVARCHAR) LIKE @keyword OR
                CAST(PetId AS NVARCHAR) LIKE @keyword OR
                CAST(VetId AS NVARCHAR) LIKE @keyword OR
                AppointmentDate LIKE @keyword OR
                AppointmentTime LIKE @keyword OR
                Notes LIKE @keyword OR
                Status LIKE @keyword";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void Appoinments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Appointments (OwnerId, PetId, VetId, AppointmentDate, AppointmentTime, Notes)
                             VALUES (@OwnerId, @PetId, @VetId, @Date, @Time, @Notes)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OwnerId", int.Parse(txtownerid.Text));
                    cmd.Parameters.AddWithValue("@PetId", int.Parse(txtpetid.Text));
                    cmd.Parameters.AddWithValue("@VetId", int.Parse(txtvetid.Text));
                    cmd.Parameters.AddWithValue("@Date", txtdate.Text);
                    cmd.Parameters.AddWithValue("@Time", txttime.Text.Trim());
                    cmd.Parameters.AddWithValue("@Notes", txtnotes.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadAppointments();
                MessageBox.Show("Appointment added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int appointmentId = Convert.ToInt32(row.Cells["AppointmentId"].Value);
                    string appointmentDate = row.Cells["AppointmentDate"].Value?.ToString();
                    string appointmentTime = row.Cells["AppointmentTime"].Value?.ToString();
                    string status = row.Cells["Status"].Value?.ToString();
                    string notes = row.Cells["Notes"].Value?.ToString();

                    string query = @"
                UPDATE Appointments
                SET AppointmentDate = @AppointmentDate,
                    AppointmentTime = @AppointmentTime,
                    Status = @Status,
                    Notes = @Notes
                WHERE AppointmentId = @AppointmentId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentDate", DateTime.Parse(appointmentDate));
                        cmd.Parameters.AddWithValue("@AppointmentTime", appointmentTime);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Notes", notes ?? string.Empty);
                        cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointments updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments(); // Refresh display
            }
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AppointmentId"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Appointments WHERE AppointmentId = @Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", appointmentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    LoadAppointments();
                    MessageBox.Show("Appointment deleted.");
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            txtappointmentId.Clear();
            txtdate.Clear();
            txtnotes.Clear();
            txttime.Clear();
            txtownerid.Clear();
            txtstatus.Clear();
            txtvetid.Clear();
            txtpetid.Clear();

        }
    }
}
