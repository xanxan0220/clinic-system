using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHavenManagementSystem.Models
{
    public static class SessionManager
    {
        public static int  LoggedInUserID { get; set; }
        public static string LoggedInUsername { get; set; }
        public static int LoggedInVetID { get; set; }
        public static string SelectedPaymentMethod { get; internal set; }
    }
}
