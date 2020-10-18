using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities 
{
    public partial class Hospital
    {
        public String Name { get; set; }

        public String Address { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public virtual ICollection<Deployment> Deployments { get; set; }

        public virtual ICollection<EmergencyCall> AssignedCalls { get; set; }

        public virtual ICollection<Ambulance> Ambulances { get; set; }

    }
}
