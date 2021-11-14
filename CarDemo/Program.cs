using System;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle= new Vehicle("Toyota","Camery","Green","1990");
            Truck truck= new Truck("Nissan", "Titan","Silver","2013","Cement Truck");
            Console.WriteLine("Vehicle Type:" + truck.Type);
            Console.WriteLine("Vehicle Make:" + truck.Make);
            Console.WriteLine("Vehicle Model:" + truck.Model);
            Console.WriteLine("Vehicle Color:" + truck.Color);
            Console.WriteLine("Vehicle Year:" + truck.Year);
            truck.Price = "$35,000";
            Console.WriteLine(truck.Price);
            truck.Start();
            truck.Drive();
            truck.Park();

            //van
            Van van = new Van("Nissan", "AgileThoughtVan", "Blue", "2019", "Normal Van");
            Console.WriteLine("Vehicle Type:" + van.Type);
            Console.WriteLine("Vehicle Make:" + van.Make);
            Console.WriteLine("Vehicle Model:" + van.Model);
            Console.WriteLine("Vehicle Color:" + van.Color);
            Console.WriteLine("Vehicle Year:" + van.Year);
            van.Start();
            van.Drive();
            van.Park();
        }
    }
}

