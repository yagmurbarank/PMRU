﻿using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Availabilities.Queries.GetAvailabilityById
{
    public class GetAvailabilityByIdQueryResponseDto
    {
        public int Id { get; set; }
        public int DoctorID { get; set; }
        public DoctorDto Doctor { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
