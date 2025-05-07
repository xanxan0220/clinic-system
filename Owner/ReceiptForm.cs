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
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(string plan, string owner, string method, decimal price)
        {
            InitializeComponent();
            //Display the receipt information
            lblPlan.Text = $"Plan: {plan}";
            lblOwner.Text = $"Owner: {owner}";
            lblPayment.Text = $"Payment Method: {method}";
            lblPrice.Text = $"Price: ₱{price:N2}";
            lblStart.Text = $"Start: {DateTime.Now:MMMM dd, yyyy}";
            lblEnd.Text = $"End: {DateTime.Now.AddYears(1):MMMM dd, yyyy}";
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            // Save the receipt as an image
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png";
                    sfd.FileName = "MembershipReceipt.png";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            MessageBox.Show("Receipt saved successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
