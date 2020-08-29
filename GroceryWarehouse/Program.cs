using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace GroceryWarehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> tovars = new List<Product>
            {
                new Product("Bred", 12, Convert.ToDateTime("07.08.2020"), 5),
                new Product("Milk", 30, Convert.ToDateTime("29.08.2020"), 30),
                new Product("Wood", 50, Convert.ToDateTime("09.05.2019"), 600),
                new Product("Sigaret", 60, Convert.ToDateTime("07.07.2016"), 365),
                new Product("Woter", 23, Convert.ToDateTime("07.07.2020"), 60),
                new Product("Eggs", 40, Convert.ToDateTime("08.08.2020"), 40)

            };

            DateTime now = DateTime.Now;

            foreach (Product tovar in tovars)
            {
                Console.WriteLine(tovar.Info());
                Console.WriteLine(tovar.Sootvetstvie(now) ? "Fresh" : "Spoiled");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
