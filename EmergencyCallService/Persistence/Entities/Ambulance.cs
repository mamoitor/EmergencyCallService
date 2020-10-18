using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Ambulance
    {
        public int RegistrationNumber { get; set; }

        public string EquipmentType { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public virtual ICollection<EmergencyCall> EmergencyCalls { get; set; }
    }
}
