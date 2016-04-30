using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_and_House_Security.Data_Entities
{
    class Sensor
    {
        public ulong id { get; set; }
        public string name { get; set; }
        public ulong fpid { get; set; }
        public int xpos { get; set; }
        public int ypos { get; set; }
        public bool enabled { get; set; }

    }
}
