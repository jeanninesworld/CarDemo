using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo5
{
    public class Vehicle5
    {
        //define properties, underscore indicates these fields belong to the actual class
        private string _make, _model, _color, _year, _price, _type;

        //constructor for the class
        public Vehicle5(string make, string model, string color, string year)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
        }

        //example of overloading the constructor
        public Vehicle5(string make, string model, string color, string year, string type)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Type = type;
        }

        public void Start()
        {
            Console.WriteLine($"Starting the {Type}.....");
            Console.WriteLine("Started.....");
        }

        public void Drive()
        {
            Console.WriteLine($"Driving the {Type}.....");
        }

        public void Park()
        {
            Console.WriteLine($"{Type}Parked....");
        }

        //create properties
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
    }
}
