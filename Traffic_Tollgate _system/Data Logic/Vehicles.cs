using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Tollgate__system.Data_Logic
{
    public class Vehicles
    {
        public string manufacturer { get; set; }
        public string colour { get; set; }
        public string reg_number { get; set; }
        public Decimal Price { get; set; }
        public string name { get; set;}

        public Vehicles()
        {
            manufacturer = "";
            colour = "";
            reg_number = "";
            name = "";
        }
        public virtual void Capture(string Manufacturer, string Colour, string Reg_number,string Name)
        {
            manufacturer = Manufacturer;
            colour = Colour;
            reg_number = Reg_number;
            name = Name;
        }
    }
}
