using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_UsingOrderedMultiDictionary
{
    public class Article : IComparable
    {
        public Article(string barcode, string vendor, string title, double price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public int CompareTo(object obj)
        {
            Article otherArticle = obj as Article;

            return this.Price.CompareTo(otherArticle.Price);
        }
    }
}
