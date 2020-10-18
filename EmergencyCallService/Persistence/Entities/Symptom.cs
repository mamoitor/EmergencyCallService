using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Symptom
    {
        public long Duration { get; set; }

        public int Severity { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Speciality> Specialities { get; set; }

        public virtual ICollection<EmergencyCall> EmergencyCalls { get; set; }
    }
}
