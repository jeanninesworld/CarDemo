using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    public class Truck : Vehicle
    {
        public Truck(string make, string model, string color, string year) : base(make, model, color, year)
        {
            Type = "Truck";
        }

        public Truck(string make, string model, string color, string year, string type) : base(make, model, color, year, type)
        {
        }
        public void OpenLiftGate()
        {
            Console.WriteLine("Lift Gate Opened");
        }

    }
}
