using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _2_FastFinding
{
    class Program
    {
        static Random random = new Random();

        static void Main()
        {
            int productsCount = 500000;
            int priceSearchesCount = 10000;

            OrderedBag<Product> products = new OrderedBag<Product>();

            double fromPrice = 0;
            double toPrice = 0;
            
            for (int i = 0; i < productsCount; i++)
            {
                products.Add(new Product("Pesho" + i, i * random.Next(100) * 2));
            }

            Stopwatch sp = new Stopwatch();
            sp.Start();
            
            for (int i = 1; i <= priceSearchesCount; i++)
            {
                fromPrice = random.Next(1000);
                toPrice = random.Next((int)(fromPrice), 100000);
                
                var rangedProducts = products.Where(p => p.Price >= fromPrice && p.Price <= toPrice).Take(20);
            }

            Console.WriteLine(sp.Elapsed);
        }
    }
}
