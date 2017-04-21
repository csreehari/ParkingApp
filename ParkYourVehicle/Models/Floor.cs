using System;
using System.Collections.Generic;

namespace ParkYourVehicle
{
    public class Floor
    {
        public int FloorNo { get; set; }
        public int NoOfParkingSlots { get; set; }
        public IEnumerable<ParkingSlot> ParkingSlots { get; set; }
    }
}