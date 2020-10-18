using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class EmergencyCallService
    {
        public EmergencyCallService()
        {
            Ambulances = new List<Ambulance>();
            Hospitals = new List<Hospital>();
            Calls = new List<EmergencyCall>();
        }


        public EmergencyCallService(Ambulance amb, Hospital hos) : this()
        {
            Ambulances.Add(amb);
            Hospitals.Add(hos);
        }
    }
}
