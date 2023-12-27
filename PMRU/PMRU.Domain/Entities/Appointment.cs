using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Domain.Common;

namespace PMRU.Domain.Entities
{
    public class Appointment : BaseEntity
    {

        public Appointment() 
        {
        }

        public Appointment(int appointmentID, int employeeID, int doctorID, DateTime appointmentDate, string appointmentHour, string description, DateTime? lastModifiedDate)
        {
            AppointmentID = appointmentID;
            EmployeeID = employeeID;
            DoctorID = doctorID;
            AppointmentDate = appointmentDate;
            AppointmentHour = appointmentHour;
            Description = description;
            LastModifiedDate = lastModifiedDate;
        }


        public int AppointmentID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentHour { get; set; }
        public string Description { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
