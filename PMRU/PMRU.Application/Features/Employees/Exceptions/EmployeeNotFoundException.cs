using MediatR;
using PMRU.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Employees.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() : base($"Bu sicil Numarası ile eşleşen çalışan bulunamadı.")
        {
        }
    }
}
