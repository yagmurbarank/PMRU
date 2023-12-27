using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Domain.Common
{
    public class BaseEntity : IEntityBase
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
