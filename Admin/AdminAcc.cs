using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHavenManagementSystem.Models;

namespace PetHavenManagementSystem
{
    public partial class AdminAcc : Form
    {
        public AdminAcc()
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

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void btndashboard_Click(object sender, EventArgs e)
        {
            loadform(new AdminDashboard());
        }

    

        private void AdminAcc_Load(object sender, EventArgs e)
        {
            loadform(new AdminDashboard());
        }

      
      
        private void mainpanel_Paint_2(object sender, PaintEventArgs e)
        {
           
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndashboard_Click_2(object sender, EventArgs e)
        {
            loadform(new AdminDashboard());
        }

        private void gunaGradientButton2_Click_1(object sender, EventArgs e)
        {
            loadform(new PetProfile());
        }

        private void gunaGradientButton3_Click_1(object sender, EventArgs e)
        {
            loadform(new ClientsProfile());
        }

        private void gunaGradientButton4_Click_1(object sender, EventArgs e)
        {
            loadform(new VetProfile());
        }

        private void gunaGradientButton5_Click_1(object sender, EventArgs e)
        {
            loadform(new Appoinments());

        }

        private void gunaGradientButton6_Click_1(object sender, EventArgs e)
        {
            loadform(new MembershipView());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
        );

            if (result == DialogResult.Yes)
            {

                ClinicHomePage clinic = new ClinicHomePage();
                clinic.Show();
                this.Close();
            }
        }
    }
    
}
