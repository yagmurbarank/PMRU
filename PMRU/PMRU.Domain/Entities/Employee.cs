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
        public Employee()
        {
            // Boş constructor, isteğe bağlı olarak burada başka başlangıç ayarları yapılabilir.
        }

        public Employee(int employeeID, string identityNumber, string name, string surname, string phone, string email,
            int locationID, Location location, int roleID, Role role, int positionID, Position position,
            int departmentID, Department department, string password, string registrationNumber, Appointment activeAppointment)
        {
            EmployeeID = employeeID;
            IdentityNumber = identityNumber;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            LocationID = locationID;
            Location = location;
            RoleID = roleID;
            Role = role;
            PositionID = positionID;
            Position = position;
            DepartmentID = departmentID;
            Department = department;
            Password = password;
            RegistrationNumber = registrationNumber;
            ActiveAppointment = activeAppointment;
        }

        public int EmployeeID { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
        public int PositionID { get; set; }
        public Position Position { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public string Password { get; set; }
        public string RegistrationNumber { get; set; }


        public Doctor Doctor { get; set; }


        // An employee can only have one appointment.
        public Appointment ActiveAppointment { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }

}
