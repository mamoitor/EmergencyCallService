using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class HospitalBased : Ambulance
    {
        public virtual Hospital IsOwnedBy { get; set; }
    }
}
