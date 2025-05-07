using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHavenManagementSystem.Models;

namespace PetHavenManagementSystem
{
    public partial class Appointment : Form
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Appointment()
        {
            InitializeComponent();
            cbxreason.Items.Add("Consultation/Checkup");
            cbxreason.Items.Add("Services");

            LoadOwners();
            cbxOwnerName.SelectedIndexChanged += cbxOwnerName_SelectedIndexChanged;

        }
        private void LoadOwners()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT OwnerId, FullName FROM Owners";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbxOwnerName.DataSource = dt;
                cbxOwnerName.DisplayMember = "FullName";
                cbxOwnerName.ValueMember = "OwnerId";
            }
        }

        private void LoadDoctors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT VetId, FullName FROM Vets";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbxDoctorname.DataSource = dt;
                cbxDoctorname.DisplayMember = "FullName";
                cbxDoctorname.ValueMember = "VetId";
            }
        }


        private void LoadPets(int ownerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PetId, PetName FROM Pets WHERE OwnerId = @OwnerId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OwnerId", ownerId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbxPetname.DataSource = dt;
                cbxPetname.DisplayMember = "PetName";
                cbxPetname.ValueMember = "PetId";
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
           
            LoadOwners();
            LoadPets(SessionManager.LoggedInUserID);
            LoadDoctors();

        }

        private void cbxreason_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxspecify.Items.Clear();

            string selectedType = cbxreason.SelectedItem.ToString();

            if (selectedType == "Consultation/Checkup")
            {
                cbxspecify.Items.Add("Skin Issues");
                cbxspecify.Items.Add("Vomiting");
                cbxspecify.Items.Add("Diarrhea");
                cbxspecify.Items.Add("Coughing");
                cbxspecify.Items.Add("Eye Problem");
                cbxspecify.Items.Add("Ear Problems");
                cbxspecify.Items.Add("Behavioral Concerns");
                cbxspecify.Items.Add("General Checkup");
                cbxspecify.Items.Add("Nutritional Advice");
                cbxspecify.Items.Add("");
            }

            else if (selectedType == "Services")
            {
                cbxspecify.Items.Add("Rabies Vaccination");
                cbxspecify.Items.Add("Dental care ");
                cbxspecify.Items.Add("Grooming");
                cbxspecify.Items.Add("Deworming");

            }
        }

        private void dtmschedule_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void cbxspecify_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cbxPetname_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxOwnerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOwnerName.SelectedValue != null)
            {
                int selectedOwnerId = (int)cbxOwnerName.SelectedValue;
                LoadPets(selectedOwnerId);
            }
        }

        private void btnschedule_Click(object sender, EventArgs e)
        {
            int ownerId = SessionManager.LoggedInUserID;
            int petId = Convert.ToInt32(cbxPetname.SelectedValue);
            int vetId = Convert.ToInt32(cbxDoctorname.SelectedValue);
            DateTime date = dtpschedule.Value.Date;
            string time = txttime.Text.Trim(); // no conversion needed
            string notes = cbxspecify.SelectedItem?.ToString(); 

            if (string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show("Please enter a time or preferred time slot.", "Missing Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Appointments 
                         (OwnerId, PetId, VetId, AppointmentDate, AppointmentTime, Notes, Status)
                         VALUES 
                         (@OwnerId, @PetId, @VetId, @Date, @Time, @Notes, 'Pending')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OwnerId", ownerId);
                cmd.Parameters.AddWithValue("@PetId", petId);
                cmd.Parameters.AddWithValue("@VetId", vetId);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Time", time); // direct string input
                cmd.Parameters.AddWithValue("@Notes", notes);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Appointment scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
         
        }
    }
}
