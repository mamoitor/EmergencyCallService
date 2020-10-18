using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Private : Ambulance
    {
        public Private(string equipty, double lati, double longt, int registration, string com)
                :base(equipty, lati, longt, registration)
        {
            CompanyName = com;
        }
    }
}
