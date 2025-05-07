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
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem
{
    public partial class OwnersPetProfile : Form
    {
        public OwnersPetProfile()
        {
            InitializeComponent();
            LoadPets();
        }
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


        private void LoadPets()
        {
            PetRepository repo = new PetRepository(connectionString);
            int ownerId = SessionManager.LoggedInUserID; 

            DataTable petsData = repo.GetPetsByOwner(ownerId);
            dataGridViewPets.DataSource = petsData;

            //Customize column headers and displays the data
            dataGridViewPets.Columns["PetID"].HeaderText = "PetID";
            dataGridViewPets.Columns["PetName"].HeaderText = "Name";
            dataGridViewPets.Columns["Species"].HeaderText = "Species";
            dataGridViewPets.Columns["Breed"].HeaderText = "Breed";
            dataGridViewPets.Columns["Color"].HeaderText = "Color";
            dataGridViewPets.Columns["Gender"].HeaderText = "Gender";
            dataGridViewPets.Columns["BirthDate"].HeaderText = "BirthDate";
            dataGridViewPets.Columns["IsNeutered"].HeaderText = "Neutered";
            dataGridViewPets.Columns["IsAdopted"].HeaderText = "Adopted";
            dataGridViewPets.Columns["Exposure"].HeaderText = "Exposure";
        }


        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            AddPet addPetForm = new AddPet();
            if (addPetForm.ShowDialog() == DialogResult.OK)
            {
                
                MessageBox.Show("Pet was saved!");
            }
            else
            {
                MessageBox.Show("Add Pet was cancelled.");
            }
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewPets.SelectedRows.Count > 0)
            {
                int petId = Convert.ToInt32(dataGridViewPets.SelectedRows[0].Cells["PetId"].Value);
                PetRepository repo = new PetRepository(connectionString);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this pet?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (repo.DeletePet(petId))
                    {
                        MessageBox.Show("Pet deleted successfully.");
                        LoadPets();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete pet.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a pet to delete.");
            }
            LoadPets();
        }

        private void OwnersPetProfile_Load(object sender, EventArgs e)
        {
            LoadPets();
            dataGridViewPets.Columns["PetID"].Visible = false;
        }
    }
}
