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
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem
{
    public partial class MembershipView : Form
    {
        public MembershipView()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void LoadMemberships()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Memberships";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["MembershipId"].ReadOnly = true;
                dataGridView1.Columns["OwnerId"].ReadOnly = true;
            }
        }

        private void MembershipView_Load(object sender, EventArgs e)
        {
            LoadMemberships();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtmembershipid.Text = row.Cells["MembershipId"].Value.ToString();
                txtownerid.Text = row.Cells["OwnerId"].Value.ToString();
                txtPlanName.Text = row.Cells["PlanName"].Value.ToString();
                txtPayment.Text = row.Cells["PaymentMethod"].Value.ToString();
                txtstatus.Text = row.Cells["Status"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();

                
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            if (dataGridView1.CurrentRow != null)
            {
                int membershipId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MembershipId"].Value);
                string planName = dataGridView1.CurrentRow.Cells["PlanName"].Value.ToString();
                string paymentMethod = dataGridView1.CurrentRow.Cells["PaymentMethod"].Value.ToString();
                string Status = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE Memberships
                        SET PlanName = @PlanName,
                        PaymentMethod = @PaymentMethod,
                        Status = @Status,
                        Price = @Price
                        WHERE MembershipId = @MembershipId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PlanName", planName);
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@Price", GetPrice(planName));
                    cmd.Parameters.AddWithValue("@MembershipId", membershipId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Membership updated successfully!");

                    LoadMemberships();
                }
            }
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete this membership?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Memberships WHERE MembershipId = @MembershipId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MembershipId", int.Parse(txtmembershipid.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membership deleted.");
                    LoadMemberships();
                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string planName = txtsearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Memberships WHERE PlanName LIKE @PlanName";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@PlanName", "%" + planName + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
            gunaButton2_Click(sender, e);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtownerid.Text.Trim());  

            // Check if the user is eligible for a new membership (expired within 30 days)
            if (UsersRepository.CanApplyNewMembership(userId))
            {
                // User is eligible for a new membership, proceed to add it
                AddNewMembership(userId);
                MessageBox.Show("A new membership has been successfully applied.");
            }
            else
            {
                // User is not eligible (membership expired more than 30 days ago)
                MessageBox.Show("This user's previous membership expired more than 30 days ago. They are not eligible for a new membership.");
            }
        }
        private void AddNewMembership(int userId)
        {
            // You can set the start date to today and the expiry date to 1 year from now
            string query = "INSERT INTO Memberships (UserId, StartDate, ExpiryDate) VALUES (@UserId, GETDATE(), DATEADD(YEAR, 1, GETDATE()))";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private decimal GetPrice(string planName)
        {
            decimal price = 0;

            switch (planName)
            {
                case "Basic":
                    price = 999;
                    break;
                case "Premium":
                    price = 2599;
                    break;
                case "VIP":
                    price = 3799;
                    break;
                default:
                    price = 0;
                    break;
            }

            return price;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
           txtmembershipid.Clear();
            txtownerid.Clear();
            txtPayment.Clear();
            txtPlanName.Clear();
            txtPrice.Clear();
            txtstatus.Clear();
            txttime.Clear();
        }
    }
}
