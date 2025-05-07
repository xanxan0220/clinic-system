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
using System.Windows.Documents;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using PetHavenManagementSystem.Models;
using PetHavenManagementSystem.Repositories;
using static System.Collections.Specialized.BitVector32;
using Session = PetHavenManagementSystem.Models.SessionManager;

namespace PetHavenManagementSystem
{
    public partial class OwnerProfile : Form
    {
        private byte[] profilePicBytes;

        public OwnerProfile()
        {
            InitializeComponent();
            cbxUsertypes.Items.Add("Owners");
           
        }
        private byte[] LoadImageAsBytes()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read the file and return the byte array
                        return File.ReadAllBytes(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., file not found, access denied)
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
            return null; 
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OwnerProfile_Load(object sender, EventArgs e)
        {
             
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileModel updatedOwner = new ProfileModel
                {
                    ID = SessionManager.LoggedInUserID,
                    Username = txtusername.Text,
                    FullName = txtfullname.Text,
                    Password = txtpassword.Text,
                    Email = txtemail.Text,
                    ContactNumber = txtphone.Text,
                    Address = txtaddress.Text,
                    Role = cbxUsertypes.SelectedItem.ToString(),
                    ProfileImage = profilePicBytes
                };

                OwnersRepository repo = new OwnersRepository();

                // Attempt to update the owner profile
                if (repo.UpdateVetProfile(updatedOwner))
                {
                    MessageBox.Show("Profile updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the profile: " + ex.Message);
                
                
            }



        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtfullname.Clear();
            txtphone.Clear();
            txtaddress.Clear();
            txtemail.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImportPic_Click(object sender, EventArgs e)
        {
            
        }

        private void pcxprofPic_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatePhoto_Click(object sender, EventArgs e)
        {
            profilePicBytes = LoadImageAsBytes();
            if (profilePicBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(profilePicBytes))
                {
                    pcxprofpic.Image = Image.FromStream(ms);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }
