using GenericsConsoleApp.Models;
using System;

namespace GenericsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //fizz buzz
            Console.WriteLine(FizzBuzz.FizzBuzzChecker<string>("Hello World"));
            Console.WriteLine(FizzBuzz.FizzBuzzChecker<Person>(new Person { Name="Niraj"}));

            //generic helper with Car class
            Car bmw = new Car {hasDefect= false, Company="bmw" };
            Car ford = new Car {hasDefect= false, Company="ford" };
            Car honda = new Car {hasDefect= true, Company="honda" };
    
            GenericsHelper<Car> carHelper = new GenericsHelper<Car>();
            carHelper.CheckItemAndAdd(bmw);
            carHelper.CheckItemAndAdd(ford);
            carHelper.CheckItemAndAdd(honda);
            var defectedCars = carHelper.GetDefectedItems();
            var nonDefectedCars = carHelper.GetNonDefectedItems();

          
            //generic helper with Computer class
            Computer windows = new Computer { hasDefect = true, Company = "microsoft" };
            Computer mac = new Computer { hasDefect = false, Company = "apple" };

            GenericsHelper<Computer> computerHelper = new GenericsHelper<Computer>();
            computerHelper.CheckItemAndAdd(windows);
            computerHelper.CheckItemAndAdd(mac);
            var defectedComputers = computerHelper.GetDefectedItems();
            var nonDefectedComputers = computerHelper.GetNonDefectedItems();
            

        }

      
    }
}
