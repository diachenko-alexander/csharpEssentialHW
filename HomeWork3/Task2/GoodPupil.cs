using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string name)
        :base (name)
        {
                
        }

        public override void Study()
        {
            Console.WriteLine($"Pupil {name} is studying GOOD");
        }

        public override void Read()
        {
            Console.WriteLine($"Pupil {name} is reading GOOD");
        }

        public override void Write()
        {
            Console.WriteLine($"Pupil {name} is writing GOOD");
        }

        public override void Relax()
        {
            Console.WriteLine($"Pupil {name} is relaxing GOOD ");
        }

    }
}
