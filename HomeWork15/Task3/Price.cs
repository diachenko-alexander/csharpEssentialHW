using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    struct Price
    {
        public string ArticleName { get; set; }
        public string ShopName { get; set; }
        public double ArticlePrice { get; set; }

        public Price(string name, string shopName, double price)
        {
            ArticleName = name;
            ShopName = shopName;
            ArticlePrice = price;
        }

        public string Show()
        {
            return string.Format($"{ArticleName} {ShopName} {ArticlePrice}");
        }
    }
}
