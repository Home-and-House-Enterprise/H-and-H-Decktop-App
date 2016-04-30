using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_and_House_Security.Data_Entities
{
    public class FloorPlan
    {
        public ulong id { get; set; }
        public string name { get; set; }
        public ulong userid { get; set; }
        public string picture { get; set; }
    }
}
