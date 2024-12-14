using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListDicPractice
{
    public class ProductList
    {
        public static void addProduct()
        {
            string productName = "";
            double price = 0;

            string filePath = @"D:\CodeGym\Homework\ListDicPractice\ProductList.txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] infoPairs = line.Split(';');

                foreach (string pair in infoPairs)
                {
                    string[] keyValue = pair.Split(':');
                    string key = keyValue[0].Trim();
                    string value = keyValue[1].Trim();

                    if(key == "product")
                    {
                        productName = value;
                    }else if(key == "price")
                    {
                        price = Convert.ToDouble(value);
                    }
                }

                Storage.products.Add(new Product(productName, price));
            }
        }
    }
}
