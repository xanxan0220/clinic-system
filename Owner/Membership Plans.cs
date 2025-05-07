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
using PetHavenManagementSystem.Owner;
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem
{
    public partial class Membership_Plans : Form
    {
        public Membership_Plans()
        {
            InitializeComponent();
        }
        private void ApplyMembership(string planName)
        {
            using (PaymentMethodForm paymentForm = new PaymentMethodForm())
            {
                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    int ownerId = SessionManager.LoggedInUserID;
                    string ownerName = SessionManager.LoggedInUsername;
                    string paymentMethod = paymentForm.SelectedPaymentMethod;
                    decimal price;

                    // Determine the price based on the plan name
                    switch (planName)
                    {
                        case "Basic":
                            price = 999;
                            break;
                        case "Premium":
                            price = 2599;
                            break;
                        case "VIP":
                            price = 3799;
                            break;
                        default:
                            MessageBox.Show("Invalid membership plan selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method if the plan name is invalid
                    }

                    // Create a MembershipModel instance
                    MembershipModel membership = new MembershipModel
                    {
                        OwnerId = ownerId,
                        PlanName = planName,
                        PaymentMethod = paymentMethod,
                        Price = price,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddYears(1), // Set the expiry date to one year from now
                        PaymentStatus = "Pending" 
                    };

                    // Apply the membership
                    MembershipRepository membershipRepo = new MembershipRepository();
                    bool success = membershipRepo.ApplyMembership(membership);
                    if (success)
                    {
                        // Open receipt form
                        ReceiptForm receipt = new ReceiptForm(planName, ownerName, paymentMethod, price);
                        receipt.ShowDialog();

                        MessageBox.Show($"Membership applied.\nStatus: Pending", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Membership application canceled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Membership_Plans_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel18_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel19_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            //Calls the ApplyMembership method with the plan name "Basic" in button click event
            ApplyMembership("Basic");
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            //Same as above but for "Premium"
            ApplyMembership("Premium");
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            //Same as above but for "VIP"
            ApplyMembership("VIP");
        }
    }
}
