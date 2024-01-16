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

        public Availability(int doctorID, DateOnly date, TimeOnly startTime, TimeOnly endTime)
        {
            DoctorID = doctorID;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
        }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModifiedDate { get; set; }
    }
}
