using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHavenManagementSystem.Models;

namespace PetHavenManagementSystem.Owner
{
    public partial class PetPhoto : Form
    {
        public PetPhoto()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private void LoadPets()
        {
            int ownerId = SessionManager.LoggedInUserID;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PetId, PetName FROM Pets WHERE OwnerId = @OwnerId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OwnerId", ownerId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbxPetList1.DataSource = dt;
                cbxPetList1.DisplayMember = "PetName";
                cbxPetList1.ValueMember = "PetId";
            }
        }
        private void SavePhoto(int petId, byte[] imageBytes)
        {
            int ownerId = SessionManager.LoggedInUserID; 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PetPhoto (PetId, OwnerId, Photo) VALUES (@PetId, @OwnerId, @Photo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PetId", petId);
                cmd.Parameters.AddWithValue("@OwnerId", ownerId); 
                cmd.Parameters.AddWithValue("@Photo", imageBytes);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Photo uploaded successfully!");
                }
                catch (SqlException sqlEx)
                {
                    
                    MessageBox.Show($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                   
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }


        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (cbxPetList1.SelectedValue != null)
            {
                int petId = Convert.ToInt32(cbxPetList1.SelectedValue);

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] imageBytes = File.ReadAllBytes(ofd.FileName);
                    SavePhoto(petId, imageBytes);
                    MessageBox.Show("Photo uploaded!");
                }
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxPetList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PetPhoto_Load(object sender, EventArgs e)
        {
            LoadPets();
        }
    }
}
