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

namespace PetHavenManagementSystem.Owner
{
    public partial class PaymentMethodForm : Form
    {
        public string SelectedPaymentMethod { get; private set; }
        public PaymentMethodForm()
        {
            InitializeComponent();
            PaymentMethod.Items.AddRange(new[] { "GCash", "Credit Card", "Cash", "PayPal" });
        }

        private void MembershipCarePlan_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedPaymentMethod = PaymentMethod.SelectedItem?.ToString() ?? "N/A";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
