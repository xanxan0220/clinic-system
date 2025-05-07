using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using PetHavenManagementSystem.Models;
using PetHavenManagementSystem.Repositories;

namespace PetHavenManagementSystem
{
    public partial class PetProfileManage : Form
    {
        public PetProfileManage()
        {
            InitializeComponent();
        }
       

        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";




        private void LoadAllPetsToGrid()
        {
            PetRepository petsRepo = new PetRepository(connectionString);
            List<OwnersModel> pets = petsRepo.GetAllPets();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pets;

            dataGridView1.Columns["OwnerID"].HeaderText = "Owner ID";
            dataGridView1.Columns["PetId"].HeaderText = "Pet ID";
            dataGridView1.Columns["PetName"].HeaderText = "Name";
            dataGridView1.Columns["Species"].HeaderText = "Species";
            dataGridView1.Columns["Breed"].HeaderText = "Breed";
            dataGridView1.Columns["Age"].HeaderText = "Age";
            dataGridView1.Columns["Color"].HeaderText = "Color";
            dataGridView1.Columns["Gender"].HeaderText = "Gender";
            dataGridView1.Columns["BirthDate"].HeaderText = "Birth Date";
            dataGridView1.Columns["IsNeutered"].HeaderText = "Neutered";
            dataGridView1.Columns["IsAdopted"].HeaderText = "Adopted";
            dataGridView1.Columns["Exposure"].HeaderText = "Exposure";
        }
        private void PetProfileManage_Load(object sender, EventArgs e)
        {
            LoadAllPetsToGrid();
            dataGridView1.Columns["PetID"].Visible = false;
            dataGridView1.Columns["OwnerID"].Visible = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            PetRepository petsRepo = new PetRepository(connectionString);
            if (!string.IsNullOrEmpty(keyword))
            {
                List<OwnersModel> results = petsRepo.SearchPets(keyword);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = results;
            }
            else
            {
                LoadAllPetsToGrid(); 
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            gunaButton1_Click(sender, e);
        }
    }
}
