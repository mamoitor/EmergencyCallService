using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Symptom
    {
        public Symptom()
        {
            this.Specialities = new List<Speciality>();
            this.EmergencyCalls = new List<EmergencyCall>();
        }

        public Symptom(String Description, long Duration, int Severity, EmergencyCall EmgCall, Speciality Spcty) : this()
        {
            this.Severity = Severity;
            this.Duration = Duration;
            this.Description = Description;
            this.Specialities.Add(Spcty);
            this.EmergencyCalls.Add(EmgCall);
        }
    }
}
