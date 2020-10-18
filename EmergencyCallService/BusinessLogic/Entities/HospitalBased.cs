using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class HospitalBased : Ambulance
    {
        public HospitalBased(string eqipmentType, double lat, double lon, int registrationNum, Hospital hospital) 
                :base(eqipmentType, lat, lon, registrationNum)
        {
            IsOwnedBy = hospital;
        }
    }
}
