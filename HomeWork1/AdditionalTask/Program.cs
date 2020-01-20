using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress myAdress = new Adress();
            myAdress.Index = 12345;
            myAdress.Country = "Ukraine";
            myAdress.City = "Kiev";
            myAdress.Street = "Proreznaja";
            myAdress.House = "4B";
            myAdress.Appartment = "1a";

            Console.WriteLine($"Index: {myAdress.Index}\nCountry: {myAdress.Country}\nCity: {myAdress.City}\nStreet: {myAdress.Street}\nHouse: {myAdress.House}\nAppartment: {myAdress.Appartment}");
            Console.ReadLine();

        }
    }
}
