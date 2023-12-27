using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Domain.Common;

namespace PMRU.Domain.Entities
{
    public class Role : BaseEntity
    {
        public Role()
        {
        }

        public Role(int roleID, string roleDescription)
        {
            RoleID = roleID;
            RoleDescription = roleDescription;
        }

        public int RoleID { get; set; }
        public string RoleDescription { get; set; }
    }
}
