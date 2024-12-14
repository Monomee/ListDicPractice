using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDicPractice
{
    public class Product
    {
        private string productName;
        private double price;

        public Product()
        {
        }

        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
        }

        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public override string ToString()
        {
            return "Product: " + productName + "\tPrice: " + price;
        }
    }
}
