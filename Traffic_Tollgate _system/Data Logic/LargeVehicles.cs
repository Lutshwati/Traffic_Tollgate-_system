using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Tollgate__system.Data_Logic
{
    class LargeVehicles : Vehicles
    {
        public string VehicleType { get; set; }
        public LargeVehicles()
        {
            VehicleType = "";
        }
        public void Put(string vehicletype, int Amount)
        {
            VehicleType = vehicletype;
            Price = Amount;
        }
    }
}
