using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name)
        :base (name)
        {
                
        }

        public override void Study()
        {
            Console.WriteLine($"Pupil {name} is studying EXCELENT");
        }

        public override void Read()
        {
            Console.WriteLine($"Pupil {name} is reading EXCELENT");
        }

        public override void Write()
        {
            Console.WriteLine($"Pupil {name} is writing EXCELENT");
        }

        public override void Relax()
        {
            Console.WriteLine($"Pupil {name} is relaxing EXCELENT");
        }

    }
}
