using System;

namespace Task2
{
    struct Worker
    {
        //string surname;
        //string position;
        int year;

        public Worker(string surname, string position, int year)
        {
            Surname = surname;
            Position = position;
            this.year = year;
        }

        public string Surname { get; set; }
        public string Position { get; set; }

        //public string Surname
        //{
        //    get
        //    {
        //        return surname;
        //    }
        //}

        //public string Position
        //{
        //    get
        //    {
        //        return position;
        //    }
        //}

        public int Year 
        { 
            get 
            {
                return year;
            }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    Console.WriteLine("Year is in the future. Please retry");
                    Year = Convert.ToInt32(Console.ReadLine());
                }
            } 
        }

        public int GetYearInCompany()
        {
            return DateTime.Now.Year - year;
        }
    }
}
