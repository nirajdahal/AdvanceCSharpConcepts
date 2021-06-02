using System;
using System.Collections.Generic;

namespace DelegatesGenericFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>() { 
            
            new Person {Name="Niraj", Age =23},
            new Person {Name="RandomName", Age =25},
            new Person {Name="NoName", Age =23}
            
            };
            var filteredList = people.FillterPeopleByTheirName();

        }
    }


    internal static class BadFilterHelper
    {

        public static List<Hero> FilterHerosByCanFLy(this List<Hero> heros)
        {
            var herosWhoCanFly = new List<Hero>();
            foreach (var hero in heros)
            {
                if (hero.CanFly)
                {
                    herosWhoCanFly.Add(hero);
                }
            }
            return herosWhoCanFly;
        }

        public static List<Person> FillterPeopleByTheirName(this List<Person> people) {

            var filteredPeople = new List<Person>();
            foreach (var person in people)
            {
                if (person.Name.ToLower().StartsWith("n"))
                {
                    filteredPeople.Add(person);
                }
            }
            return filteredPeople;
        }
    
    }

    internal class Person
    {

        public string Name { get; set; }

        public int Age { get; set; }
    }

   internal class Hero
    {

        public bool CanFly { get; set; }

        public string CharacterName { get; set; }
    }

}
