using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Deployment
    {
        public int Floor { get; set; }

        public int NumEmployees { get; set; }

        public virtual Hospital BasedIn{ get; set; }

        public virtual Speciality HasSpecialty { get; set; }
    }
}
