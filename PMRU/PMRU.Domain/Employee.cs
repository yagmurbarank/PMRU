using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Domain
{
    public class Employee
    {
        public int RegistrationNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Role { get; set; }
    }
}
