using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    public class Van : Vehicle
    {
        public Van(string make, string model, string color, string year, string type) : base(make, model, color, year, type){}

        public void Start()
        {
            invokeKeylessStart();
        }
        public void invokeKeylessStart()
        {
            Console.WriteLine($"Started{Type} automatically  with key fob");
        }
    }
}
