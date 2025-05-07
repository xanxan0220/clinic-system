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
    public partial class PetProfile : Form
    {
        public PetProfile()
        {
            InitializeComponent();
            cmbNeutered.Items.Add("Yes");
            cmbNeutered.Items.Add("No");
            
        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void LoadPets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pets";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                
                dataGridView1.Columns["PetID"].ReadOnly = true;
            }
        }


        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PetProfile_Load(object sender, EventArgs e)
        {
            LoadPets();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtPetID.Text = dataGridView1.CurrentRow.Cells["PetID"].Value.ToString();
                txtOwnerID.Text = dataGridView1.CurrentRow.Cells["OwnerID"].Value.ToString();
                txtPetName.Text = dataGridView1.CurrentRow.Cells["PetName"].Value.ToString();
                txtSpecies.Text = dataGridView1.CurrentRow.Cells["Species"].Value.ToString();
                txtBreed.Text = dataGridView1.CurrentRow.Cells["Breed"].Value.ToString();
                txtAge.Text = dataGridView1.CurrentRow.Cells["Age"].Value.ToString();
                txtGender.Text = dataGridView1.CurrentRow.Cells["Gender"].Value.ToString();
                txtColor.Text = dataGridView1.CurrentRow.Cells["Color"].Value.ToString();
                dtpBirthdate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["BirthDate"].Value);
                txtIsAdopted.Text = dataGridView1.CurrentRow.Cells["IsAdopted"].Value.ToString();
                bool isNeutered = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsNeutered"].Value);
                txtExposure.Text = dataGridView1.CurrentRow.Cells["Exposure"].Value.ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Pets (OwnerID, PetName, Species, Breed, Age, Gender, Color, BirthDate, IsAdopted, IsNeutered, Exposure)
                         VALUES (@OwnerID, @PetName, @Species, @Breed, @Age, @Gender, @Color, @BirthDate, @IsAdopted, @IsNeutered, @Exposure)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OwnerID", int.Parse(txtOwnerID.Text));
                cmd.Parameters.AddWithValue("@PetName", txtPetName.Text);
                cmd.Parameters.AddWithValue("@Species", txtSpecies.Text);
                cmd.Parameters.AddWithValue("@Breed", txtBreed.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@BirthDate", dtpBirthdate.Value);
                cmd.Parameters.AddWithValue("@IsAdopted", txtIsAdopted.Text);
                bool isNeutered = cmbNeutered.SelectedItem.ToString() == "Yes";
                cmd.Parameters.AddWithValue("@IsNeutered", isNeutered);
                cmd.Parameters.AddWithValue("@Exposure", txtExposure.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pet added!");
                LoadPets();
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

                    SqlCommand cmd = new SqlCommand(@"UPDATE Pets SET 
                    PetName = @PetName, Species = @Species, Breed = @Breed, Age = @Age,
                    Gender = @Gender, Color = @Color, BirthDate = @BirthDate,
                    IsAdopted = @IsAdopted, IsNeutered = @IsNeutered, Exposure = @Exposure
                    WHERE PetID = @PetID", conn);

                    cmd.Parameters.AddWithValue("@PetID", row.Cells["PetID"].Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@PetName", row.Cells["PetName"].Value ?? "");
                    cmd.Parameters.AddWithValue("@Species", row.Cells["Species"].Value ?? "");
                    cmd.Parameters.AddWithValue("@Breed", row.Cells["Breed"].Value ?? "");
                    cmd.Parameters.AddWithValue("@Age", row.Cells["Age"].Value ?? "");
                    cmd.Parameters.AddWithValue("@Gender", row.Cells["Gender"].Value ?? "");
                    cmd.Parameters.AddWithValue("@Color", row.Cells["Color"].Value ?? "");
                    cmd.Parameters.AddWithValue("@BirthDate", row.Cells["BirthDate"].Value ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsAdopted", row.Cells["IsAdopted"].Value ?? "0");
                    cmd.Parameters.AddWithValue("@IsNeutered", row.Cells["IsNeutered"].Value ?? false);
                    cmd.Parameters.AddWithValue("@Exposure", row.Cells["Exposure"].Value ?? "");

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("All pet records updated.");
                LoadPets();
            }
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int petId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PetID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Pets WHERE PetID = @PetID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PetID", petId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pet deleted!");
                    LoadPets();
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pets WHERE PetName LIKE @search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            gunaButton1_Click(sender, e);
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            txtOwnerID.Clear();
            txtPetID.Clear();
            txtPetName.Clear();
            txtIsAdopted.Clear();
            txtSpecies.Clear();
            txtGender.Clear();
            txtAge.Clear();
            txtBreed.Clear();
            txtColor.Clear();
            txtExposure.Clear();
            cmbNeutered.Items.Clear();
        }
    }
}
