using GenericCsvApp.Contracts;
using GenericCsvApp.Events;
using GenericCsvApp.Factory;
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
            IDataAccess<Car> car = CreateFactory.Create<Car>();
            List<Car> cars = new List<Car>(){
            new Car{ Name="Fox", Company="Honda", Model="101", Price=15.55M},
            new Car{ Name="Destiny", Company="Bmw", Model="501", Price=66.55M},
            new Car{ Name="GzDamn", Company="Suzuki", Model="6001", Price=86.55M}
            };
            car.CreateFile(cars, "C:/Users/tulshi/source/repos/AdvanceCSharpConcepts/GenericCsvApp/cars.csv");

       

            IDataAccess<Person> person= CreateFactory.Create<Person>();
            List<Person> people = new List<Person>() {

                new Person{FirstName="NirajDamn",LastName="Dahal", Age=23},
                new Person{FirstName="Nirajala",LastName="Dahal", Age=26},
                new Person{FirstName="Saraswoti",LastName="Dahal Pokhrel", Age=48},
                new Person{FirstName="Tulasi",LastName="Dahal ", Age=48}

                };
            person.CreateFile(people, "C:/Users/tulshi/source/repos/AdvanceCSharpConcepts/GenericCsvApp/people.csv");

        }

      
    }
}
