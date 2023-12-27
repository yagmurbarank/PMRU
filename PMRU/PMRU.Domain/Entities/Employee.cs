using PMRU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public int PositionID { get; set; }
        public Position Position { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public string RegistrationNumber { get; set; }

        // An employee can only have one appointment.
        public int AppointmentId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Appointment? Appointment { get; set; }
    }

}
