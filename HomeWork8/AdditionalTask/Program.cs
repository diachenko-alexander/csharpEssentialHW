using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static class BirthdayHelper
        {
            public static int GetDaysToNextBirthday (DateTime dateBirth)
            {
                DateTime today = DateTime.Now;
                DateTime nextBirth = new DateTime(today.Year, dateBirth.Month, dateBirth.Day);
                TimeSpan left = nextBirth - today;

                if (left.Days < 0)
                {
                    left = nextBirth.AddYears(1) - today;
                }

                return left.Days;
            }
        }

        static void Main(string[] args)
        {
            DateTime dateBirthNextYear = new DateTime(2000, 01, 01);
            Console.WriteLine(BirthdayHelper.GetDaysToNextBirthday (dateBirthNextYear));

            DateTime dateBirthThisYear = new DateTime(2000, 03, 01);
            Console.WriteLine(BirthdayHelper.GetDaysToNextBirthday(dateBirthThisYear));
            
        }
    }
}
