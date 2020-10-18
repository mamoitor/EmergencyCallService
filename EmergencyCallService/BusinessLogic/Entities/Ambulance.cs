using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Ambulance
    {
        public Ambulance()
        {
            EmergencyCalls = new List<EmergencyCall>();
        }
        public Ambulance(string equipty, double lati, double longt, int registration) : this()
        {
            EquipmentType = equipty;
            Latitude = lati;
            Longitude = longt;
            RegistrationNumber = registration;
        }
    }
}
