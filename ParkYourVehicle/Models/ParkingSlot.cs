using System;
using System.Collections.Generic;

namespace ParkYourVehicle
{
    public class ParkingSlot
    {
        public string ParkingSlotID { get; set; }
        public Floor FloorDetail { get; set; }
        public Car<IManufacturer> AllottedTo { get; set; } 
        public bool IsAvailable { get; set; } = true;
        public IEnumerable<Car<IManufacturer>> Cars { get; set; }
    }
}