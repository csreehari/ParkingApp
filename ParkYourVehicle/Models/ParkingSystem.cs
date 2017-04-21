using System;
using System.Collections.Generic;

namespace ParkYourVehicle
{
    public class ParkingSystem
    {
        public int NoOfFloors { get; set; }
        public ICollection<Floor> Floors { get; set; }
    }
}
