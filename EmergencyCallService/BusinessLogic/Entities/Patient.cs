using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyCallService.Entities
{
    public partial class Patient
    {
        public Patient(string address, int age, string dni, char gender, string name, string phone, string sur)
        {
            Dni = dni;
            Name = name;
            Surname = sur;
            Gender = gender;
            Age = age;
            PhoneNumber = phone;
            Address = address;
        }
    }
}
