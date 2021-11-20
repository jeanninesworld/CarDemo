using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemoLecture5
{
    public class Van5 : Vehicle5
    {
        public Van5(string make, string model, string color, string year, string type) : base(make, model, color, year, type){}

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
