using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemoLecture5
{
    public class Truck5 : Vehicle5
    {
        public Truck5(string make, string model, string color, string year) : base(make, model, color, year)
        {
            Type = "Truck";
        }

        public Truck5(string make, string model, string color, string year, string type) : base(make, model, color, year, type)
        {
        }
        public void OpenLiftGate()
        {
            Console.WriteLine("Lift Gate Opened");
        }

    }
}
