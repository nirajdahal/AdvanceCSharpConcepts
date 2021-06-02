using DelegatesGenericFilter.Filters;
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
            var filteredPeople =  people.FilterTtems(x => x.Name.ToLower().StartsWith("r"));

            List<Hero> heros = new List<Hero>()
            {

                new Hero{CanFly= true, CharacterName="Shaktiman"},
                new Hero{CanFly= true, CharacterName="Bat"},
                new Hero{CanFly= false, CharacterName="Captain America."},
            };
            var filteredHeros = heros.FilterTtems(x => x.CanFly);
        }
    }

}
