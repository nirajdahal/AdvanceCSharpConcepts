using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesDemoConsole
{
    class Program
    {
        public static ShoppingCart cart = new ShoppingCart();
        static void Main(string[] args)
        {
            PopulateShoppingCar();
            Console.WriteLine("The discout amount is : " + 
                cart.GenerateTotal(
                ShoppingCartHelper.CalculateTotal,
                ShoppingCartHelper.CalculateDiscount,
                ShoppingCartHelper.LookForUserAlert
                ) ); 


        }

        public static void PopulateShoppingCar()
        {

            List<Product> products = new List<Product>()
            {
                new Product { ProductName = "Computer", ProductCode = 102, Price = 256 },
                new Product { ProductName = "Laptopr", ProductCode = 105, Price = 555 }
            };
            cart.Products = products;
           
        }


    }
}
