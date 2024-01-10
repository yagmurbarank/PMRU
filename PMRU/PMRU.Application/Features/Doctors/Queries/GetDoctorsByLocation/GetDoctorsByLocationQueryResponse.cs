﻿using PMRU.Application.DTOs;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorByLocation
{
    public class GetDoctorByLocationQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public LocationDto Location { get; set; }

     
        public IList<AvailabilityDto> Availability { get; set; }
    }
}