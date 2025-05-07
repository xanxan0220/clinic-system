using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetHavenManagementSystem
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ClinicHomePage frm = new ClinicHomePage();
            frm.Show();
            this.Hide();
        }
    }
}
