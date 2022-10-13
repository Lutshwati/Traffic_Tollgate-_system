using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Tollgate__system.Data_Logic
{
    class Light__Vehicles : Vehicles
    {
        public string VehicleType { get; set; }
        public Light__Vehicles()
        {
            VehicleType = "";
        }
        public void Put( string vehicletype, Decimal Amount)
        {
            VehicleType = vehicletype;
            Price = Amount;
        }
    }
}
