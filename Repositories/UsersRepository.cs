
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHavenManagementSystem.Models;

namespace PetHavenManagementSystem.Repositories
{
    public class UsersRepository
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private static string connectionstring = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static string GetUserTypeByEmail(string email)
        {
            
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                if (EmailExistsInTable(conn, email, "Owners")) return "Owner";
                if (EmailExistsInTable(conn, email, "Vets")) return "Vet";
                if (EmailExistsInTable(conn, email, "Admins")) return "Admin";
            }

            return null;
        }

        private static bool EmailExistsInTable(SqlConnection conn, string email, string tableName)
        {
            // Check if the email exists in the specified table
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE Email = @Email";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public static bool UpdatePassword(string email, string newPassword, string userType)
        {
            // Validate the userType
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                string table = null;
                switch (userType)
                {
                    case "Owner":
                        table = "Owners";
                        break;
                    case "Vet":
                        table = "Vets";
                        break;
                    case "Admin":
                        table = "Admins";
                        break;
                    default:
                        return false; 
                }

                if (table == null) return false;
                // Update the password in the specified table
                string query = $"UPDATE {table} SET Password = @Password WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", email);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool RegisterUser(UsersModel user)
        {
            // Validate the user role
            string table = GetTableName(user.Role);
            if (string.IsNullOrEmpty(table)) return false;
            //Query for registering a user
            try
            {
              
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $@"
                INSERT INTO {table} (Username, Password, FullName, Email, ContactNumber, Address,ProfileImage)
                VALUES (@Username, @Password, @FullName, @Email, @ContactNumber, @Address,@ProfileImage)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@ContactNumber", user.ContactNumber ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Address", user.Address ?? string.Empty);
                    cmd.Parameters.AddWithValue("@ProfileImage", (object)user.ProfileImage ?? DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public UsersModel Login(string role, string username, string password)
        {
            string table = GetTableName(role);
            if (string.IsNullOrEmpty(table)) return null;

            try
            {
                //sql query for login
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM {table} WHERE Username = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    // Execute the query and read the result
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        if (reader.Read())
                        {
                            SessionManager.LoggedInUserID = Convert.ToInt32(reader[0]);
                            SessionManager.LoggedInUsername = reader["FullName"].ToString();
                            return new UsersModel
                            {
                                ID = Convert.ToInt32(reader[0]),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString(),
                                ContactNumber = reader["ContactNumber"] == DBNull.Value ? null : reader["ContactNumber"].ToString(),
                                Role = role,
                                ProfileImage = reader["ProfileImage"] as byte[]
                            };
                        }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

            return null;
        }

        private string GetTableName(string role)
        {
            switch (role)
            {
                case "Owners":
                    return "Owners";
                case "Doctor":
                    return "Vets";
                case "Admins":
                    return "Admins";
                default:
                    return null;
            }
        }
        public static bool CanApplyNewMembership(int userId)
        {
            //Query to check if the admin can apply for a new membership 
            string query = @"
                SELECT COUNT(*) 
                FROM Memberships
                WHERE UserId = @UserId
                  AND DATEDIFF(DAY, ExpiryDate, GETDATE()) <= 30
                  AND ExpiryDate < GETDATE()";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    int expiredMembershipCount = (int)cmd.ExecuteScalar();
                    return expiredMembershipCount > 0;
                }
            }
        }
    }
}
