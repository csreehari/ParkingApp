using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkYourVehicle
{
    public class Car<T> where T: IManufacturer
    {
        public T CarManufacturer { get; set; }
        public string CarOwnerName { get; set; }
        public bool IsAllocatedSlot { get; set; } = false;
    }
}
