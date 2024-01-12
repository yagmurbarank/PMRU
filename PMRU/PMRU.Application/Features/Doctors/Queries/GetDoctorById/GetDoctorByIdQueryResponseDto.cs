﻿using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorById
{
    public class GetDoctorByIdQueryResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public LocationDto Location { get; set; }
        public IList<AvailabilityDto> Availabilities { get; set; }
    }
}
