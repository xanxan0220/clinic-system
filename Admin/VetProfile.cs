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

namespace PetHavenManagementSystem
{
    public partial class VetProfile : Form
    {
        public VetProfile()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void LoadVets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Vets";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void VetProfile_Load(object sender, EventArgs e)
        {
            LoadVets();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtfullname.Text = row.Cells["FullName"].Value?.ToString();
                txtusernmae.Text = row.Cells["Username"].Value?.ToString();
                txtpassword.Text = row.Cells["Password"].Value?.ToString();
                txtemail.Text = row.Cells["Email"].Value?.ToString();
                txtrole.Text = row.Cells["Role"].Value?.ToString();
                txtcontactnumber.Text = row.Cells["ContactNumber"].Value?.ToString();
            }
        }
        private void SearchOwners(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Vets 
                         WHERE FullName LIKE @Keyword 
                            OR Email LIKE @Keyword 
                            OR ContactNumber LIKE @Keyword";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Vets (FullName, Username, Password, Email, Role, ContactNumber)
                         VALUES (@FullName, @Username, @Password, @Email, @Role, @ContactNumber)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", txtfullname.Text.Trim());
                cmd.Parameters.AddWithValue("@Username", txtusernmae.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", txtrole.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", txtcontactnumber.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctors added successfully.");
                LoadVets();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int vetId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["VetID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Vets SET 
                                FullName = @FullName, 
                                Username = @Username, 
                                Password = @Password, 
                                Email = @Email, 
                                Role = @Role, 
                                ContactNumber = @ContactNumber 
                             WHERE VetID = @VetID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", txtfullname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", txtusernmae.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Role", txtrole.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNumber", txtcontactnumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@VetID", vetId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor updated successfully.");
                    LoadVets();

                }
            }
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int vetsID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["VetID"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this Doctor?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Vets WHERE VetID = @VetID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@VetID", vetsID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vet deleted successfully.");
                        LoadVets();
                    }
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                SearchOwners(keyword);
            }
            else
            {
                LoadVets();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(sender, e);
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            txtcontactnumber.Clear();
            txtemail.Clear();
            txtfullname.Clear();
            txtemail.Clear();
            txtrole.Clear();
            txtusernmae.Clear();
            txtpassword.Clear();
        }
    }
    
}
