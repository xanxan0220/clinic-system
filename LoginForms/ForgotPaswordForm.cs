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

namespace PetHavenManagementSystem.LoginForms
{
    public partial class ForgotPaswordForm : Form
    {
        public ForgotPaswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            string userType = UsersRepository.GetUserTypeByEmail(email);
            if (userType != null)
            {
                ResetPassword resetForm = new ResetPassword(email, userType);
                resetForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email not found.");
            }
        }
        private void ForgotPaswordForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
