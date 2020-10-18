using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Speciality
    {
        public Speciality()
        {
            Symptoms = new List<Symptom>();
            Deployments = new List<Deployment>();
        }
        public Speciality(string name,  Deployment deployment) : this()
        {
            Deployments.Add(deployment);
            Name = name;
        }
    }
}
