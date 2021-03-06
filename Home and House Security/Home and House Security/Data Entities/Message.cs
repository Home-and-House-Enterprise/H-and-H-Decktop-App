﻿using Home_and_House_Security.Data_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_and_House_Security
{
    public class Message
    {
        public string name { get; set; }
        public string type { get; set; }
        public string message { get; set; }
        public string messageType { get; set; }
        public ulong id { get; set; }
        public ulong deviceID { get; set; }
        public string status { get; set; }
        public string value { get; set; }
        public FloorPlan[] floorPlans { get; set; }
        public Sensor[] sensors { get; set; }
    }
}
