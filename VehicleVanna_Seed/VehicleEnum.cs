using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleVanna_Test
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
        public string AutoMake { get; set; }
        public string AutoModel { get; set; }
        public string AutoYear { get; set; }
        public int listPrice { get; set; }
        public VehicleTypes AutoType { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }
}
