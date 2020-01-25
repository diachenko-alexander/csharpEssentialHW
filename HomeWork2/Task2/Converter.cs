using System;

namespace Task2
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ConvertGrnTo(double grnAmmount, string destinationCurrency)
        {
            double userCurrency = GetUserCurrency(destinationCurrency);
            if (userCurrency <= 0)
            {
                Console.WriteLine($"Currency mast be greater than 0");
                return 0;
            }
            else
            {
                return grnAmmount / userCurrency;
            }
        }

        public double ConvertToGrn(double currencyAmmount, string destinationCurrency)
        {
            return currencyAmmount * GetUserCurrency(destinationCurrency);
        }

        private double GetUserCurrency(string userInput)
        {
            double result = 0;
            switch (userInput.ToLower())
            {
                case "usd":
                    result = usd;
                    break;
                case "eur":
                    result = eur;
                    break;
                case "rub":
                    result = rub;
                    break;
                default:
                    Console.WriteLine("Not supported currency");
                    break;
            }
            return result;
        }

    }
}
