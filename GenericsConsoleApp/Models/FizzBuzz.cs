using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsConsoleApp.Models
{
    public class FizzBuzz
    {
        public static string FizzBuzzChecker<T>(T item) where T : class
        {

            var itemLength = item.ToString().Length;

            string output = "";
            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }
            return output;
        }
    }
}
