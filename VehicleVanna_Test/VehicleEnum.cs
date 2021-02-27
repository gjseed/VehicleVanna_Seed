using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleVanna_Test
{
    
    class VehicleEnum
    {
        public enum VehicleTypes
        {
            Car,
            SportsCar,
            Truck,
            Motorcycle,
            MotorHome,
        }
        public class AutoEnum
        {
            public AutoEnum(string make, string model, string year, int lprice, string type, string email, string first, string last)
            {
                AutoMake = make;
                AutoModel = model;
                AutoYear = year;
                listPrice = lprice;
                FName = first;
                LName = last;
                Email = email;
                AutoType = (VehicleTypes) Enum.Parse(typeof(VehicleTypes), type);
            }

            public string AutoMake { get; set; }
            public string AutoModel { get; set; }
            public string AutoYear { get; set; }
            public int listPrice { get; set; }
            public VehicleTypes AutoType { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Email { get; set; }
        }
    }
}
