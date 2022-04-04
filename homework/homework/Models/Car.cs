using homework.Interfeys;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Models
{
    class Car :IEngine
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }
        public int HorsePower { get; set ; }
        public int TankSize { get ; set ; }
        public double CurrentOil { get; set ; }
        public int FuelType { get; set; }
    }
}
