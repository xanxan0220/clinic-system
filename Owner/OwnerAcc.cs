using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using PetHavenManagementSystem.Models;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace PetHavenManagementSystem
{
    public partial class OwnerAcc : Form
    {


        public OwnerAcc()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
        }

        public void LoadOwnerDashboard(UsersModel user)
        {
            lblOwnername.Text = SessionManager.LoggedInUsername;


            if (user.ProfileImage != null)
            {
                using (MemoryStream ms = new MemoryStream(user.ProfileImage))
                {
                    pcxProfileImage.Image = Image.FromStream(ms);
                }
            }
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

        private void OwnerAcc_Load(object sender, EventArgs e)
        {
            loadform(new OwnerDashboard());


        }



        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            loadform(new OwnerProfile());
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            loadform(new OwnerDashboard());

        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pcxprofilepic_Click(object sender, EventArgs e)
        {
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void paneldashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpetmanager_Click(object sender, EventArgs e)
        {
            loadform(new OwnersPetProfile());
        }

        private void btnmembership_Click(object sender, EventArgs e)
        {
            loadform(new Membership_Plans());
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            loadform(new OwnerProfile());
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            loadform(new OwnerDashboard());
        }

        private void btnappointment_Click(object sender, EventArgs e)
        {
            loadform(new Appointment());
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


        private void btnnotifs_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT Status, AppointmentDate, AppointmentTime
                FROM Appointments
                WHERE OwnerId = @OwnerId AND Status IN ('Accepted', 'Rejected')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OwnerId", SessionManager.LoggedInUserID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string status = reader["Status"].ToString();
                        string date = Convert.ToDateTime(reader["AppointmentDate"]).ToShortDateString();
                        string time = reader["AppointmentTime"].ToString();

                        notifyIcon1.BalloonTipTitle = "Appointment Update";
                        notifyIcon1.BalloonTipText = $"Your appointment on {date} at {time} was {status.ToLower()} by the vet.";
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.ShowBalloonTip(3000); // Show for 3 seconds
                    }
                }
                else
                {
                    notifyIcon1.BalloonTipTitle = "Appointment Update";
                    notifyIcon1.BalloonTipText = "No updates found for your appointments.";
                    notifyIcon1.ShowBalloonTip(2000);
                }
            }
        }

        private void gunaImageButton1_Click_1(object sender, EventArgs e)
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
