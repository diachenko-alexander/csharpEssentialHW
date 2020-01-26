using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BadPupil: Pupil
    {
        public BadPupil(string name)
        : base(name)
        {

        }

        public override void Study()
        {
            Console.WriteLine($"Pupil {name} is studying BAD");
        }

        public override void Read()
        {
            Console.WriteLine($"Pupil {name} is reading BAD");
        }

        public override void Write()
        {
            Console.WriteLine($"Pupil {name} is writing BAD");
        }

        public override void Relax()
        {
            Console.WriteLine($"Pupil {name} is relaxing BAD");
        }
    }
}
