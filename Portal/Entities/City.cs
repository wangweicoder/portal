using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Entities
{
    public class City
    {
        public int CityID { get; set; }
        public string CityNo { get; set; }
        public string CityName { get; set; }
        public DateTime CreateTime { get; set; } =DateTime.Now;
    }
}
