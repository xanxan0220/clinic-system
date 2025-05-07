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
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem
{
    public partial class MembershipManage : Form
    {
        public MembershipManage()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
       

        private void LoadOwnersToGrid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT FullName, Email, ContactNumber, Address
            FROM Owners";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;

            
                dataGridView1.Columns["FullName"].HeaderText = "Full Name";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["ContactNumber"].HeaderText = "Contact Number";
                dataGridView1.Columns["Address"].HeaderText = "Address";
            }
        }

        private void MembershipManage_Load(object sender, EventArgs e)
        {
            LoadOwnersToGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadOwnersToGrid();
            }
            btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT FullName, Email, ContactNumber, Address
                FROM Owners
                WHERE FullName LIKE @SearchTerm";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["FullName"].HeaderText = "Full Name";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["ContactNumber"].HeaderText = "Contact Number";
                dataGridView1.Columns["Address"].HeaderText = "Address";
            }
        }
    }
}
