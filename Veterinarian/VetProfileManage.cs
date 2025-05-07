using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHavenManagementSystem.Models;
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem
{
    public partial class VetProfileManage : Form
    {
        private byte[] profilePicBytes;

        public VetProfileManage()
        {
            InitializeComponent();
            cbxUsertypes.Items.Add("Doctors");
        }
        private byte[] LoadProfile()
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
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return null; // Return null if the dialog was canceled or an error occurred
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VetProfileManage_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileModel updatedVet = new ProfileModel
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

                if (repo.UpdateVetProfile(updatedVet))
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

        private void btnUpdatePhoto_Click(object sender, EventArgs e)
        {
            profilePicBytes = LoadProfile();
            if (profilePicBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(profilePicBytes))
                {
                    pcxprofpic.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
