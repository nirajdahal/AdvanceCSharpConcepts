using GenericCsvApp.Events;
using GenericCsvApp.Helper;
using GenericCsvApp.Models;
using System;
using System.Collections.Generic;

namespace GenericCsvApp
{
    class Program
    {
     
        static void Main(string[] args)
        {
            CsvFileHandler<Car> createCar = new CsvFileHandler<Car>();

            createCar.CreateFile(new List<Car>(){
            new Car{ Name="FoxDarn", Company="Honda", Model="101", Price=15.55M},
            new Car{ Name="Destiny", Company="Bmw", Model="501", Price=66.55M},
            new Car{ Name="Gz", Company="Suzuki", Model="6001", Price=86.55M}

            });
        
        
        }

        private static void EventForCar_BadWordDetected(object sender, Car e)
        {
            Console.WriteLine("Badword found");
            Console.WriteLine("Badword found");
            Console.WriteLine("Badword found");
        }
    }
}
