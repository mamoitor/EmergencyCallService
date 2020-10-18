using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class EmergencyCallService
    {
        public virtual ICollection<Ambulance> Ambulances { get; set; }

        public virtual ICollection<Hospital> Hospitals { get; set; }

        public virtual ICollection<EmergencyCall> Calls { get; set; }
    }
}

