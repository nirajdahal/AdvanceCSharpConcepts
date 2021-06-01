using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesDemoConsole
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }

        public delegate void MentionTotal(List<Product> products, decimal price) ;

       
        public decimal GenerateTotal(MentionTotal mentionTotal,
            Func<List<Product>, decimal, decimal> mentionDiscount,
            Action<string> alertUser
            
            )
        {
            var subTotal = Products.Sum(x => x.Price);
            mentionTotal(Products, subTotal);
            alertUser("Hey we are discounting");
            return mentionDiscount(Products,subTotal);
           
        }
    }
}