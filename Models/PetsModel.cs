using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHavenManagementSystem.Models
{
    public class OwnersModel
    {
        public int PetId { get; set; }

        public int OwnerID {  get; set; }
        public string PetName { get; set; }

        public string Species { get; set; }

        public string Breed { get; set; }

        public string Age { get; set; }

        public string Color { get; set; }

        public string Gender { get; set; }
        public string BirthDate { get; set; }

        public bool IsNeutered { get; set; }
        public string IsAdopted { get; set; }
        public string Exposure { get; set; }




    }
}
