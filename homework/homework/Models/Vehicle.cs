using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Models
{
    abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        public double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
