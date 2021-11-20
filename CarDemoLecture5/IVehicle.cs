using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemoLecture5
{
    public interface IVehicle
    {
        public string Type { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Price {  get; set; }

        public void Start();
        public void Drive();
        public void Park();
    }
}
