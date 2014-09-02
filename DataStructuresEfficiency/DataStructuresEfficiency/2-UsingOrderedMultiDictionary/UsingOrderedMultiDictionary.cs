using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _2_UsingOrderedMultiDictionary
{
    class UsingOrderedMultiDictionary
    {
        private static Random random = new Random();

        static void Main()
        {
            char[] symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            OrderedMultiDictionary<double, Article> articles = new OrderedMultiDictionary<double, Article>(true);
            string barcode = string.Empty;
            string vendor = string.Empty;
            string title = string.Empty;
            double price = 0;

            for (int i = 0; i < 100000; i++)
            {
                barcode = GenerateRandomString(symbols);
                vendor = GenerateRandomString(symbols);
                title = GenerateRandomString(symbols);
                price = i * random.Next(100);

                articles.Add(price, new Article(barcode, vendor, title, price));
            }

            Console.Write("From price: ");
            double fromPrice = double.Parse(Console.ReadLine());
            Console.Write("To price: ");
            double toPrice = double.Parse(Console.ReadLine());

            var filteredArticles = articles.Range(fromPrice, true, toPrice, true);
            int foundArticles = 0;

            foreach (var pair in filteredArticles)
            {
                foreach (var article in pair.Value)
                {
                    foundArticles++;
                    Console.WriteLine(article.Barcode);
                }
            }

            Console.WriteLine("{0} articles were found", foundArticles);
        }

        public static string GenerateRandomString(char[] symbols)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0, len = random.Next(5, 10); i < len; i++)
            {
                int randomNumber = random.Next(26);

                result.Append(symbols[randomNumber]);
            }

            return result.ToString();
        }
    }
}
