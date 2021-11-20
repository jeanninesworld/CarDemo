using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemoLecture5
{
    public class Car : IVehicle
    {
        private string _make, _model, _color, _year, _price, _type;
        public Car(string make, string model, string color, string year) 
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;

        }

        public String Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public String Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public String Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public String Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public String Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public String Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public void Drive()
        {
            Console.WriteLine("Driving car....");
            Console.WriteLine("Still Driving...");
            Console.WriteLine("...............");
        }

        public void Park()
        {
            Console.WriteLine("Parking car....");
            Console.WriteLine("");
        }

        public void Start()
        {
            Console.WriteLine("Starting car....");
            Console.WriteLine("Car Started...");
        }
    }
}
