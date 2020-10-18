using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class EmergencyCall
    {
        public long Latitude { get; set; }

        public long Longitude { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public virtual Patient CallPatient { get; set; }

        public virtual Hospital? IsAssignedToHospital { get; set; }

        public virtual ICollection<Symptom> Symptoms { get; set; }

        public virtual Ambulance? IsAssignedToAmbulance { get; set; }

    }
}
