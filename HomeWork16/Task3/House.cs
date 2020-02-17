namespace Task3
{
    class House
    {
        Country country;
        string street;
        uint number;

        public House(Country country, string street, uint number)
        {
            this.country = country;
            this.street = street;
            this.number = number;
        }

        public Country Country
        {
            get 
            {
                return country;
            }
            set
            {
                country = value;
            }
             
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public uint Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public House Clone()
        {
            return this;
        }

        public House DeepClone()
        {
            return new House(country.Clone() as Country, this.Street, this.Number);
        }

       
    }
}

