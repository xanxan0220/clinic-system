using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHavenManagementSystem.Models;

namespace PetHavenManagementSystem
{
    public partial class VetAcc : Form
    {
        public VetAcc()
        {
            InitializeComponent();
        }


        private void loadform(object form)
        {
            if (this.dashboard.Controls.Count > 0)
                this.dashboard.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.dashboard.Controls.Add(f);
            this.dashboard.Tag = f;
            f.Show();
        }
        public void LoadVetDashboard(UsersModel user)
        {
            lblvetname.Text = user.FullName;

            if (user.ProfileImage != null)
            {
                using (MemoryStream ms = new MemoryStream(user.ProfileImage))
                {
                    pcxProfileImage.Image = Image.FromStream(ms);
                }
            }
        }
        private void VetAcc_Load(object sender, EventArgs e)
        {
            loadform(new VetDashboard());
        }

        private void btnprofilemanager_Click(object sender, EventArgs e)
        {
            loadform(new VetProfileManage());
        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnpetmanager_Click(object sender, EventArgs e)
        {
            loadform(new PetProfileManage());
        }

        private void btnmembership_Click(object sender, EventArgs e)
        {
            loadform(new MembershipManage());
        }

        private void btnappointment_Click(object sender, EventArgs e)
        {
            loadform(new AppointmentManage());
        }

        private void dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            loadform (new VetDashboard ());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void pcxprofilepic_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnotifs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                
                SessionManager.LoggedInUserID = 0;
                SessionManager.LoggedInUsername = null;

                
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Close(); 
            }
        }
    }
}
