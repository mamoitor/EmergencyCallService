using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Deployment
    {
        public Deployment(int floor, int numEmp, Hospital hp, Speciality sp)
        {
            Floor = floor;
            NumEmployees = numEmp;
            BasedIn = hp;
            HasSpecialty = sp;
        }
    }
}
