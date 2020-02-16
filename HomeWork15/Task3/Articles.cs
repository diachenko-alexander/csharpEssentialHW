using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Articles
    {
        Price[] prices = null;

        public Articles()
        {
            prices = new Price[0];
        }

        public void Add (Price price)
        {
            Price[] tempPrice = new Price[prices.Length + 1];
            prices.CopyTo(tempPrice, 0);
            tempPrice[prices.Length] = price;
            prices = tempPrice;
            prices = prices.OrderBy(pr => price.ArticleName).ToArray<Price>();
        }

        public void AddByConsole()
        {
            double pricesAddCount;
            string articleName;
            string shopName;
            double articlePrice;

            Console.Write("Enter count of articles:");
            string userInputAddCount = Console.ReadLine();

            try
            {
                pricesAddCount = Convert.ToInt32(userInputAddCount);
            }
            catch (Exception)
            {
                pricesAddCount = 1;
                Console.WriteLine("You entered invalid value. You can add only 1 article");
            }

            for (int i = 0; i < pricesAddCount; i++)
            {
                Console.Write("Enter article name:");
                articleName = Console.ReadLine();

                Console.Write("Enter shop name:");
                shopName = Console.ReadLine();

                Console.Write("Enter price:");
                string userInputPrice = Console.ReadLine();

                try
                {
                    articlePrice = Convert.ToDouble(userInputPrice);
                }
                catch (Exception)
                {
                    articlePrice = 0;
                    Console.WriteLine("You entered invalid price. Price is set to 0.00");                    
                }

                Price price = new Price(articleName, shopName, articlePrice);
                Add(price);
            }
        }

        public string this[string index] 
        {
            get
            {

                try
                {
                    return prices[Convert.ToInt32(index) - 1].Show();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return string.Format("No such article");
                }
            }
        }

    }
}
