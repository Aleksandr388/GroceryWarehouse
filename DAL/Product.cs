using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public int ShelfLife;
        public DateTime DataOfManufactyre;


        public string Info()
        {
            return $"Название продукта - {Name}\nЦена - {Price}\nDate of manufacture - {DataOfManufactyre}\nShelf Life - {ShelfLife} days";
        }

        public bool Sootvetstvie(DateTime currentDate)
        {
            return (currentDate < DataOfManufactyre + new TimeSpan(ShelfLife, 0, 0, 0));
        }

        public Product(string name, int price, DateTime dataOfManufactyre, int shelfLife)
        {
            Name = name;
            Price = price;
            DataOfManufactyre = dataOfManufactyre;
            ShelfLife = shelfLife;
        }
    }
}