using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Hospital
    {
        public Hospital()
        {
            AssignedCalls = new List<EmergencyCall>();
            Deployments = new List<Deployment>();
            Ambulances = new List<Ambulance>();
        }

        // Relaxed constructor
        public Hospital(String Address, double Lat, double Longit, String Name) : this()
        {
            this.Address = Address;
            this.Latitude = Lat;
            this.Longitude = Longit;
            this.Name = Name;
        }
    }
}
