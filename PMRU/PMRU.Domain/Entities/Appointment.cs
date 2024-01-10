using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Domain.Common;

namespace PMRU.Domain.Entities
{
    
    public class Appointment : EntityBase
    {
        public Appointment()
        {
            
        }
        public Appointment(int doctorID, int employeeId, DateOnly appointmentDate, TimeOnly appointmentHour, string description)
        {
            DoctorID = doctorID;
            EmployeeID = employeeId;
            AppointmentDate = appointmentDate;
            AppointmentHour = appointmentHour;
            Description = description;
        }
        public int EmployeeID { get; set; }
        public int AppointmentID { get; set; }
        public Employee Employee { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentHour { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModifiedDate { get; set; }
    }
}
