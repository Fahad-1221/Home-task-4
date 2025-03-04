using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book();
            Book1.Title = "OOP";
            Book1.Author = "Sir Abdul Qadeer";
            Book1.ISBN = "0123456789";
            Book1.Price = 1200;
            Book1.DisplayBookInfo();
            Book1.ApplyDiscount();

            Console.WriteLine();
            Book Book2 = new Book();
            Book2.Title = "DLD";
            Book2.Author = "Mam Sana";
            Book2.ISBN = "6667778881";
            Book2.Price = 2650;
            Book2.DisplayBookInfo();
            Book2.ApplyDiscount();

            Console.WriteLine();
            Book Book3 = new Book();
            Book3.Title = "DBS";
            Book3.Author = "Mam Rida";
            Book3.ISBN = "2122021777";
            Book3.Price = 2650;
            Book3.DisplayBookInfo();
            Book3.ApplyDiscount();

        }
    }
}
