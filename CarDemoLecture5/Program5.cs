using CarDemoLecture5;
using System;

namespace CarDemoLecture5
{
    class Program5
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle= new Vehicle("Toyota","Camery","Green","1990");
            /*  Truck5 truck= new Truck5("Nissan", "Titan","Silver","2013","Cement Truck");
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
              Van5 van = new Van5("Nissan", "AgileThoughtVan", "Blue", "2019", "Normal Van");
              Console.WriteLine("Vehicle Type:" + van.Type);
              Console.WriteLine("Vehicle Make:" + van.Make);
              Console.WriteLine("Vehicle Model:" + van.Model);
              Console.WriteLine("Vehicle Color:" + van.Color);
              Console.WriteLine("Vehicle Year:" + van.Year);
              van.Start();
              van.Drive();
              van.Park();           


 
            Car car = new Car("Nissan", "Ultima", "Blue", "2019");
            Console.WriteLine("Vehicle Type:" + car.Type);
            Console.WriteLine("Vehicle Make:" + car.Make);
            Console.WriteLine("Vehicle Model:" + car.Model);
            Console.WriteLine("Vehicle Color:" + car.Color);
            Console.WriteLine("Vehicle Year:" + car.Year);
            car.Start();
            car.Drive();
            car.Park(); */


            //linq Exercise

          /*  string[] names = { "Bill", "Steve", "James", "Mohan" };
            var name = names.Where(e => e.Contains("Bill") || e.Contains("Mohan"));

            foreach (String nm in name)
            {
                Console.WriteLine(nm);
            } */

            Car[] carArray =
            {
                new Car("Nissan","Ultima","Blue","2019") { },
                new Car("Toyota","Camry","Red","2020") { },
                new Car("Ford","Explorer","Black","2012") { },
                new Car("Ford","Titan","Black","2012") { }
            };

            //only getting the first result that matches.
            var result2 = (carArray).FirstOrDefault(t => t.Year.Equals("2012") && t.Color.Equals("Black"));
            Console.WriteLine("The Car model that match our query is " + result2.Model);

            //Will give you more results from using where
            var result3 = (carArray).Where(t => t.Year.Equals("2012") && t.Color.Equals("Black"));

            foreach (var carResult in result3)
            {
                Console.WriteLine("The car models that matched our query is " + carResult.Model);

            }
            
            
            /* var result = from car in carArray
                         where car.Year.Equals("2012")
                         where car.Color.Equals("Black")
                         select car;

            foreach (var carResult in result)

            Console.WriteLine("The Car that matched our query is " + carResult.Model); */
        } 
    }
}

