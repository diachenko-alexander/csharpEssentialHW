using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        public string Article { get; set; }

        public int Quantity { get; set; }

        public Invoice (int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private double GetArticlePrise()
        {
            double articlePrise = 0;

            switch (Article.ToLower())
            {
                case "mouse":
                    articlePrise = 100;
                    break;
                case "keyboard":
                    articlePrise = 300;
                    break;
                default:
                    Console.WriteLine("No such Article");
                    break;
            }
            return articlePrise;
        }

        public double CalculateInvoice (bool nds)
        {
            if (nds)
            {
                return (GetArticlePrise() + (GetArticlePrise() * 0.2)) * Quantity;
            }
            else return GetArticlePrise() * Quantity;
        }
    }
}
