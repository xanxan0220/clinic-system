using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHavenManagementSystem.Models;

namespace PetHavenManagementSystem.Repositories
{
    public class PetRepository
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public DataTable GetPetsByOwner(int ownerId)
        {
            DataTable petsTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT PetId, PetName, Species, Breed, Age, Gender,Color, BirthDate, 
                                    IsNeutered, IsAdopted, Exposure
                             FROM Pets
                             WHERE OwnerID = @OwnerID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OwnerID", ownerId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(petsTable);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading pets: " + ex.Message);
            }

            return petsTable;
        }

        public bool AddPet(OwnersModel pet, int ownerId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Pets 
                                    (PetName, Species, Breed, Age, Gender, Color, BirthDate, IsNeutered, IsAdopted, Exposure, OwnerID) 
                                     VALUES 
                                    (@PetName, @Species, @Breed, @Age, @Gender, @Color, @BirthDate, @IsNeutered, @IsAdopted, @Exposure, @OwnerID)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PetName", pet.PetName);
                    cmd.Parameters.AddWithValue("@Species", pet.Species);
                    cmd.Parameters.AddWithValue("@Breed", pet.Breed);
                    cmd.Parameters.AddWithValue("@Age", pet.Age);
                    cmd.Parameters.AddWithValue("@Color", pet.Color);
                    cmd.Parameters.AddWithValue("@Gender", pet.Gender);
                    cmd.Parameters.AddWithValue("@BirthDate", pet.BirthDate);
                    cmd.Parameters.AddWithValue("@IsNeutered", pet.IsNeutered);
                    cmd.Parameters.AddWithValue("@IsAdopted", pet.IsAdopted);
                    cmd.Parameters.AddWithValue("@Exposure", pet.Exposure);
                    cmd.Parameters.AddWithValue("@OwnerID", ownerId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding pet: " + ex.Message);
                return false;
            }
        }


        public bool DeletePet(int petId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Pets WHERE PetId = @PetId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PetId", petId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error deleting pet: " + ex.Message);
                return false;
            }
        }

        public List<OwnersModel> GetAllPets()
        {
            List<OwnersModel> petsList = new List<OwnersModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pets";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    petsList.Add(new OwnersModel
                    {
                        PetId = Convert.ToInt32(reader["PetId"]),
                        OwnerID = Convert.ToInt32(reader["OwnerID"]),
                        PetName = reader["PetName"].ToString(),
                        Species = reader["Species"].ToString(),
                        Breed = reader["Breed"].ToString(),
                        Age = reader["Age"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        BirthDate = reader["BirthDate"].ToString(),
                        IsNeutered = Convert.ToBoolean(reader["IsNeutered"]),
                        IsAdopted = reader["IsAdopted"].ToString(),
                        Exposure = reader["Exposure"].ToString()
                    });
                }
            }

            return petsList;
        }
    

    public List<OwnersModel> SearchPets(string keyword)
        {
            List<OwnersModel> petsList = new List<OwnersModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT * FROM Pets
            WHERE PetName LIKE @keyword OR Species LIKE @keyword OR Breed LIKE @keyword";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    petsList.Add(new OwnersModel
                    {
                        PetId = Convert.ToInt32(reader["PetId"]),
                        OwnerID = Convert.ToInt32(reader["OwnerID"]),
                        PetName = reader["PetName"].ToString(),
                        Species = reader["Species"].ToString(),
                        Breed = reader["Breed"].ToString(),
                        Age = reader["Age"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        BirthDate = reader["BirthDate"].ToString(),
                        IsNeutered = Convert.ToBoolean(reader["IsNeutered"]),
                        IsAdopted = reader["IsAdopted"].ToString(),
                        Exposure = reader["Exposure"].ToString()
                    });
                }
            }

            return petsList;
        }

    }
}
