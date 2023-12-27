using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Domain.Common;

namespace PMRU.Domain.Entities
{
    public class Location : BaseEntity
    {
        public Location()
        {
            // Boş constructor, isteğe bağlı olarak burada başka başlangıç ayarları yapılabilir.
        }

        public Location(int locationID, string locationDescription, bool isLocationCenter)
        {
            LocationID = locationID;
            LocationDescription = locationDescription;
            IsLocationCenter = isLocationCenter;
        }

        public int LocationID { get; set; }
        public string LocationDescription { get; set; }
        public bool IsLocationCenter { get; set; }
    }

}
