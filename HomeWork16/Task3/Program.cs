using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Country fr = new Country("France");
            House myHose1 = new House(fr, "some street1", 1);
            //House clone = myHose1.Clone();
            House clone = myHose1.DeepClone();
            clone.Country = new Country("spain");

            Console.WriteLine($"{myHose1.Country.CountryName} {myHose1.Street} {myHose1.Number}");
            Console.WriteLine($"{clone.Country.CountryName} {clone.Street} {clone.Number}");
            

            
           
           

            

           

        }
    }
}
