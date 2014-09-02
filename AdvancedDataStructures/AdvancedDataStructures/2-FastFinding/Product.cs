using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FastFinding
{
    public class Product : IComparable
    {
        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public int CompareTo(object obj)
        {
            Product otherProduct = obj as Product;

            return this.Price.CompareTo(otherProduct.Price);
        }
    }
}
