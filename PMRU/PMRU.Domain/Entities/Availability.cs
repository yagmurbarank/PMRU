using PMRU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Domain.Entities
{
    public class Availability: EntityBase
    {
        public Availability() 
        {
        
        }

        public Availability(int doctorID, DayOfWeek day, TimeSpan startTime, TimeSpan endTime)
        {
            DoctorID = doctorID;
            Day = day;
            StartTime = startTime;
            EndTime = endTime;
        }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModifiedDate { get; set; }
    }
}
