using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using PetHavenManagementSystem.Models;
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem
{
    public partial class AddPet : Form
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public AddPet()
        {
            InitializeComponent();
            btnSave.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            cbmGender.Items.Add("Male");
            cbmGender.Items.Add("Female");
            cbmGender.Items.Add("Other");

            cbxNeutered.Items.Add("Yes");
            cbxNeutered.Items.Add("No");

            cbmExposure.Items.Add("Indoor Only");
            cbmExposure.Items.Add("Outdoor Exposure");
            
        }

     

        private void AddPet_Load(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbmNeutered_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmExposure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPetname.Text) || string.IsNullOrWhiteSpace(txtSpecies.Text))
            {
                MessageBox.Show("Please fill in required fields.");
                return;
            }

            OwnersModel newPet = new OwnersModel
            {
                PetName = txtPetname.Text,
                Species = txtSpecies.Text,
                Breed = txtBreed.Text,
                Age = txtAge.Text,
                Gender = cbmGender.SelectedItem.ToString(),
                Color = txtColor.Text,
                BirthDate = dtpBirthdate.Value.ToString("yyyy-MM-dd"),
                IsAdopted = txtHowlong.Text,
                IsNeutered = cbxNeutered.SelectedItem.ToString() == "Yes",
                Exposure = cbmExposure.SelectedItem.ToString(),
                OwnerID = SessionManager.LoggedInUserID 
            };
            
            PetRepository repo = new PetRepository(connectionString);
            bool isPetAdded = repo.AddPet(newPet, SessionManager.LoggedInUserID);
            if (isPetAdded)
            {
                MessageBox.Show("Pet added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add pet.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    
}
