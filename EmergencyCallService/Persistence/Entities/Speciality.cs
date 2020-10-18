using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Speciality
    {
        public virtual ICollection<Deployment> Deployments { get; set; }

        public virtual ICollection<Symptom> Symptoms { get; set; }

        public virtual String Name { get; set; }
    }
}
