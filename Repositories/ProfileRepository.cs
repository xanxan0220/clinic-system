using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic.ApplicationServices;
using PetHavenManagementSystem.Models;

namespace PetHavenManagementSystem.Repositories
{
    public class OwnersRepository
    {

        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


        public bool UpdateVetProfile(ProfileModel owner)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    int ownerId = SessionManager.LoggedInUserID;

                    string query = @"UPDATE Owners SET 
                             Username = @Username,
                             FullName = @FullName,
                             Password = @Password,
                             Email = @Email,
                             ContactNumber = @ContactNumber,
                             Address = @Address,
                             ProfileImage = @ProfileImage,
                             Role = @Role
                             WHERE OwnerID = @OwnerID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Username", owner.Username);
                    cmd.Parameters.AddWithValue("@FullName", owner.FullName);
                    cmd.Parameters.AddWithValue("@Password", owner.Password);
                    cmd.Parameters.AddWithValue("@Email", owner.Email);
                    cmd.Parameters.AddWithValue("@ContactNumber", owner.ContactNumber);
                    cmd.Parameters.AddWithValue("@Address", owner.Address);
                    cmd.Parameters.AddWithValue("@ProfileImage", (object)owner.ProfileImage ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Role", owner.Role);
                    cmd.Parameters.AddWithValue("@OwnerID", owner.ID);

                    // Open the connection
                    con.Open();
                    // Execute the query
                    return cmd.ExecuteNonQuery() > 0; // Return true if one or more rows are affected
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions 
                MessageBox.Show("SQL Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                // Handle general exceptions 
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }


        public bool UpdateVetsProfile(ProfileModel vet)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    int vetId = SessionManager.LoggedInUserID;

                    string query = @"UPDATE Owners SET 
                             Username = @Username,
                             FullName = @FullName,
                             Password = @Password,
                             Email = @Email,
                             ContactNumber = @ContactNumber,
                             Address = @Address,
                             ProfileImage = @ProfileImage,
                             Role = @Role
                             WHERE OwnerID = @OwnerID";

                    SqlCommand cmd = new SqlCommand(query, con);


                    cmd.Parameters.AddWithValue("@Username", vet.Username);
                    cmd.Parameters.AddWithValue("@FullName", vet.FullName);
                    cmd.Parameters.AddWithValue("@Password", vet.Password);
                    cmd.Parameters.AddWithValue("@Email", vet.Email);
                    cmd.Parameters.AddWithValue("@ContactNumber", vet.ContactNumber);
                    cmd.Parameters.AddWithValue("@Address", vet.Address);
                    cmd.Parameters.AddWithValue("@ProfileImage", (object)vet.ProfileImage ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Role", vet.Role);
                    cmd.Parameters.AddWithValue("@OwnerID", vet.ID);


                    con.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

    }
}

