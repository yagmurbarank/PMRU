using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Domain.Common;

namespace PMRU.Domain.Entities
{

    public class Department : BaseEntity
    {
        public Department()
        {
        }

        public Department(int departmentID, string departmentDescription)
        {
            DepartmentID = departmentID;
            DepartmentDescription = departmentDescription;
        }


        public int DepartmentID { get; set; }
        public string DepartmentDescription { get; set; }
    }
}
