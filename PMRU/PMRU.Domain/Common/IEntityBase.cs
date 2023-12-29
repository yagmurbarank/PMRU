using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Domain.Common
{
    public interface IEntityBase
    {
        int Id { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
