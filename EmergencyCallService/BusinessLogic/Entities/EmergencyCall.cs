using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class EmergencyCall
    {
        public EmergencyCall()
        {
            Symptoms = new List<Symptom>();
        }
        public EmergencyCall(DateTime date, long lat, long lon, TimeSpan time, Patient pat, Symptom sym) : this()
        {
            Date = date;
            Latitude = lat;
            Longitude = lon;
            Time = time;
            CallPatient = pat;
            Symptoms.Add(sym);
            IsAssignedToAmbulance = null;
            IsAssignedToHospital = null;
        }
    }
}
