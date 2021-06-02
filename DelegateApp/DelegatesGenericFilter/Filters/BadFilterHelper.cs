using System.Collections.Generic;

namespace DelegatesGenericFilter
{
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

        public static List<Hero> FilterHerosByTheirName(this List<Hero> heros)
        {
            var herosWhoCanFly = new List<Hero>();
            foreach (var hero in heros)
            {
                if (hero.CharacterName.ToLower().StartsWith("A"))
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


        public static List<Person> FillterPeopleByTheirAge(this List<Person> people)
        {

            var filteredPeople = new List<Person>();
            foreach (var person in people)
            {
                if (person.Age<15)
                {
                    filteredPeople.Add(person);
                }
            }
            return filteredPeople;
        }
    }

}
