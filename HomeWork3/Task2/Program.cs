using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil excelentPupil1 = new ExcelentPupil("Sergey");
            Pupil excelentPupil2 = new ExcelentPupil("Oleg");
            Pupil goodPupil = new GoodPupil("Sasha");
            Pupil badPupil = new BadPupil("Mark");

            ClassRoom classA = new ClassRoom(excelentPupil1, excelentPupil2, goodPupil, badPupil);
            
            classA.HowClassStudy();
            classA.HowClassRead();
            classA.HowClassWrite();
            classA.HowClassRest();

            Console.ReadKey();
        }
    }
}
