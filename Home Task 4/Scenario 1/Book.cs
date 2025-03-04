using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1
{
    class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Name of the Book: {Title}");
            Console.WriteLine($"Author of the Book: {Author}");
            Console.WriteLine($"ISBN of the Book: {ISBN}");
            Console.WriteLine($"Price of the Book: {Price}");  
        }
        public void ApplyDiscount()
        {
            double discount = Price * 0.4;
            double DiscountPrice = Price - discount;
            Console.WriteLine($"Price of the book after 40% OFF: {DiscountPrice}"); 
        }
    }
}
