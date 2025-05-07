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
    public class MembershipRepository
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public bool ApplyMembership(MembershipModel membership)
        {
            DateTime startDate = DateTime.Now;
            DateTime expiryDate = startDate.AddYears(1);
            string status = "Pending";
            decimal price = 0;

            switch (membership.PlanName)
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
                    return false;
            }

            try
            {
                int ownerId = SessionManager.LoggedInUserID;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check for existing membership for this owner
                    string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM Memberships 
                    WHERE OwnerId = @OwnerId AND 
                          (Status IN ('Pending', 'Active') OR (Status = 'Expired' AND DATEDIFF(DAY, ExpiryDate, GETDATE()) <= 30))";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@OwnerId", ownerId);
                        int existing = (int)checkCmd.ExecuteScalar();

                        // Check if an active or pending membership exists, or expired within the last 30 days
                        if (existing > 0)
                        {
                            MessageBox.Show("You already have a pending, active, or recently expired membership.", "Duplicate Membership", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    // Proceed to insert new membership
                    string insertQuery = @"
                INSERT INTO Memberships 
                (OwnerId, PlanName, StartDate, ExpiryDate, PaymentMethod, Status, Price)
                VALUES 
                (@OwnerId, @PlanName, @StartDate, @ExpiryDate, @PaymentMethod, @Status, @Price)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@OwnerId", ownerId);
                        cmd.Parameters.AddWithValue("@PlanName", membership.PlanName);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                        cmd.Parameters.AddWithValue("@PaymentMethod", membership.PaymentMethod);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Price", price);

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying membership: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
     
      

    }
}
