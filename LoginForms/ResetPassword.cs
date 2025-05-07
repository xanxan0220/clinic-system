using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHavenManagementSystem.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PetHavenManagementSystem.LoginForms
{
    public partial class ResetPassword : Form
    {
        private string _email;
        private string _userType;
        public ResetPassword(string email, string accountType)
        {
            InitializeComponent();
            _email = email;
            _userType = accountType;
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string newPass = txtnewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            bool success = UsersRepository.UpdatePassword(_email, newPass, _userType);
            if (success)
            {
                MessageBox.Show("Password reset successful.");
                LoginForm form = new LoginForm();
                form.Show();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Something went wrong. Try again.");
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ForgotPaswordForm form = new ForgotPaswordForm();
            form.Show();
            this.Hide();

        }
    }
}
