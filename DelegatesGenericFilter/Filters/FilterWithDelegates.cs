using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesGenericFilter.Filters
{
    public static class FilterWithDelegatesForHeros
    {
        public  delegate bool ApplyCondition(Hero hero); 
        public static List<Hero> FilterHeros(this List<Hero> heros, ApplyCondition applyCondition)
        {
            var filteredHeros = new List<Hero>();
            foreach (var hero in heros)
            {
                if (applyCondition(hero))
                {
                    filteredHeros.Add(hero);
                }
            }
            return filteredHeros;
        }
    }

    public static class FilterWithDelegatesForPerson
    {
        public delegate bool ApplyCondition(Person person);
        public static List<Person> FilterPeople (this List<Person> people, ApplyCondition applyCondition)
        {
            var filteredPeople = new List<Person>();
            foreach (var person in people)
            {
                if (applyCondition(person))
                {
                    filteredPeople.Add(person);
                }
            }
            return filteredPeople;
        }
    }
}
