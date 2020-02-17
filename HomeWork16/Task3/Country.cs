using System;

namespace Task3
{
    class Country : ICloneable
    {
       string countryName;

        public Country(string country)
        {
            countryName = country;
            
        }

        
        public string CountryName { get { return countryName; } }

        public object Clone()
        {
            return new Country(this.CountryName);
        }


    }
}
