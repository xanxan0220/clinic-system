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
using PetHavenManagementSystem.Owner;

namespace PetHavenManagementSystem
{
    public partial class OwnerDashboard : Form
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public OwnerDashboard()
        {
            InitializeComponent();
        }
        private void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void LoadPetPhotosForOwner()
        {
            int ownerId = SessionManager.LoggedInUserID;

            // Handles the connection to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT pet.PetName, photo.Photo
                    FROM PetPhoto photo
                    INNER JOIN Pets pet ON photo.PetId = pet.PetId
                    WHERE pet.OwnerId = @OwnerId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OwnerId", ownerId);
                
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    
                    tableLayoutPanel2.Controls.Clear();
                    // Set the table layout panel to have 3 columns
                    //This autamtically added the rows,panels,picture boxes and labels
                    while (reader.Read())
                    {
                        byte[] imgBytes = (byte[])reader["Photo"];
                        string petName = reader["PetName"].ToString();

                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            PictureBox pic = new PictureBox();
                            pic.Image = Image.FromStream(ms);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Width = 300; 
                            pic.Height = 300; 
                            pic.Location = new Point(0, 0);
                            pic.BorderStyle = BorderStyle.FixedSingle;

                            Label lbl = new Label();
                            lbl.Text = petName;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.Width = pic.Width;
                            lbl.Height = 30;
                            lbl.Font = new Font("Segoi UI", 11, FontStyle.Regular);
                            lbl.Location = new Point(0, pic.Bottom + 5);

                            Panel panel = new Panel();
                            panel.Width = 310; 
                            panel.Height = pic.Height + lbl.Height + 10;
                            panel.Margin = new Padding(10); 
                            panel.Controls.Add(pic);
                            panel.Controls.Add(lbl);



                            tableLayoutPanel2.Controls.Add(panel);

                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    
                    MessageBox.Show($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnmembership_Click(object sender, EventArgs e)
        {
            
        }

        private void OwnerDashboard_Load(object sender, EventArgs e)
        {
            LoadPetPhotosForOwner();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmembership_Click_1(object sender, EventArgs e)
        {
            loadform(new Membership_Plans());
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            PetPhoto photo = new PetPhoto();
            photo.ShowDialog();
        }

        private void pcxthirdpetpic_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void gunaElipsePanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
