using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using PetHavenManagementSystem.Components;
using PetHavenManagementSystem.LoginForms;
using PetHavenManagementSystem.Models;
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm() 
        {
            InitializeComponent();
            //Add roles to the combo box
            cmbrole.Items.Add("Admins");
            cmbrole.Items.Add("Doctor");
            cmbrole.Items.Add("Owners");
            txtusername.Focus();
        }

        private void cbxusertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ClinicHomePage form = new ClinicHomePage();
            form.Show();
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the password based on the checkbox state
            txtpassword.PasswordChar = cbxshowpass.Checked ? '\0' : '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
            txtpassword.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            // Validate input fields
            string role = cmbrole.Text; 
            string username = txtusername.Text;
            string password = txtpassword.Text;
            // Check if any of the fields are empty
            if (string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Check if the username and password are valid
            UsersRepository repo = new UsersRepository();
            var loggedUser = repo.Login(role, username, password);
            
            if (loggedUser != null)
            {
                switch (role)
                {
                    case "Owners":
                        OwnerAcc frm = new OwnerAcc();
                        frm.LoadOwnerDashboard(loggedUser);  
                        frm.Show();
                        this.Hide();
                        break;
                    case "Doctor":
                        VetAcc form = new VetAcc();
                        form.LoadVetDashboard(loggedUser);
                        form.Show();
                        this.Hide();
                        break;
                    case "Admins":
                        AdminAcc admin = new AdminAcc();
                        admin.Show();
                        this.Hide();
                        break;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ForgotPaswordForm form = new ForgotPaswordForm();
            form.Show();
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
