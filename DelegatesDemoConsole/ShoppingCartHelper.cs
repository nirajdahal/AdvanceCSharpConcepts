using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesDemoConsole
{
    public static class ShoppingCartHelper
    {
        public static decimal CalculateDiscount(List<Product> products, decimal price)
        {
            if (price > 500)
            {
                return price * 0.9M;
            }

            if (price > 200)
            {
                return price * 0.95M;
            }
            return price;
        }

        public static void CalculateTotal(List<Product> products, decimal price)
        {
            Console.WriteLine("The total price was: " + price);

        }
   
        public static void LookForUserAlert(string text)
        {
            Console.WriteLine(text);
        }
    
    }
}
