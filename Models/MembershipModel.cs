using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHavenManagementSystem.Models
{
    public class MembershipModel
    {
        public int MembershipId { get; set; }
        public int OwnerId { get; set; }
        public string PlanName { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
    }
}
