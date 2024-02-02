using PMRU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Domain.Entities
{
    public class Doctor : EntityBase
    {
        public Doctor()
        {

        }

        public Doctor(string identityNumber, string registrationNumber, string name, string surname, string phone, string email, int locationID)
        {
            IdentityNumber = identityNumber;
            RegistrationNumber = registrationNumber;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            LocationID = locationID;
        }


        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public string RegistrationNumber { get; set; }

        // The doctor may have more than one appointment.
        public ICollection<Appointment> Appointments { get; set; }

        // Information on the day and time the doctor is available
        public ICollection<Availability> Availabilities { get; set; }
    }
}
