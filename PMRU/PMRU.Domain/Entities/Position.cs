using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Domain.Common;

namespace PMRU.Domain.Entities
{
    public class Position : BaseEntity
    {
        public Position()
        {
        }

        public Position(int positionID, string positionDescription)
        {
            PositionID = positionID;
            PositionDescription = positionDescription;
        }
        public int PositionID { get; set; }
        public string PositionDescription { get; set; }
    }
}
