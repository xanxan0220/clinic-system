using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHavenManagementSystem.Models;
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem.Components
{
    public partial class RegistrationForm : Form
    {
        private byte[] profilePicBytes;

        public RegistrationForm()
        {
            InitializeComponent();
            cmbrole.Items.Add("Doctor");
            cmbrole.Items.Add("Owners");
         


        }

        private byte[] LoadImageAsBytes()
        {
            // OpenFileDialog to select an image
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return File.ReadAllBytes(ofd.FileName);
                }
            }
            return null;
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
           
            UsersRepository repo = new UsersRepository();
            UsersModel newUser = new UsersModel
            {
                Username = username.Text,
                Password = txtpassword.Text,
                FullName = txtfullname.Text,
                Role = cmbrole.Text,
                Email = txtemail.Text,
                ContactNumber = txtphone.Text,
                Address = txtaddress.Text,
                ProfileImage = profilePicBytes
            };

            bool isRegistered = repo.RegisterUser(newUser);
            MessageBox.Show(isRegistered ? "Registered Succesfully!" : "Failed to Register!");

        }
        

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbxusertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AdminRegisterForm_Load(object sender, EventArgs e)
        {
           
        }

        private void linklbalreadyhaveanaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImageImport_Click(object sender, EventArgs e)
        {
            profilePicBytes = LoadImageAsBytes();
            if (profilePicBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(profilePicBytes))
                {
                    ppcxProfileImport.BackgroundImage = Image.FromStream(ms);
                }
            }
        }

        private void ppcxProfileImport_Paint(object sender, PaintEventArgs e)
        {

        }
    }
  }

