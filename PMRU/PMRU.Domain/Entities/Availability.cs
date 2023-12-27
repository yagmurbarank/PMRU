using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Domain.Entities
{
    public class Availability
    {
        public Availability()
        {
        }

        public Availability(int availabilityID, int doctorID, DayOfWeek day, TimeSpan startTime, TimeSpan endTime)
        {
            AvailabilityID = availabilityID;
            DoctorID = doctorID;
            Day = day;
            StartTime = startTime;
            EndTime = endTime;
        }

        public int AvailabilityID { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
