using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyDate
    {
        DateTime date;

        public MyDate(DateTime date)
        {
            this.date = date;
        }

        public static MyDate operator -(MyDate d1, MyDate d2)
        {
            TimeSpan span = d1.date - d2.date;
            DateTime result = d1.date.AddDays(-span.Days);
            return new MyDate(result);
        }

        public static MyDate operator +(MyDate d1, MyDate d2)
        {
            TimeSpan span = d1.date - d2.date;
            DateTime result = d1.date.AddDays(span.Days);
            return new MyDate(result);
        }

        public static MyDate Add (MyDate d1, MyDate d2)
        {
            return d1 + d2;
        }

        public static MyDate Remove(MyDate d1, MyDate d2)
        {
            return d1 - d2;
        }

        public override string ToString()
        {
            return "date is: "  + date;
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDate d1 = new MyDate(new DateTime(2020, 01, 01));
            MyDate d2 = new MyDate(new DateTime(2019, 01, 01));

            Console.WriteLine(d1);
            Console.WriteLine(MyDate.Add(d1, d2).ToString());
            Console.WriteLine(MyDate.Remove(d1,d2));
            Console.ReadKey();

        }
    }
}
