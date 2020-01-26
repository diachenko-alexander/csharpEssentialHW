using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Pupil
    {
        protected string name;
        
        
        public Pupil()
        {

        }

        public Pupil(string name)
        {
            this.name = name;
        }

        public virtual void Study()
        {
            Console.WriteLine($"Pupil {name} is studying");
        }

        public virtual void Read()
        {
            Console.WriteLine($"Pupil {name} is reading");
        }

        public virtual void Write()
        {
            Console.WriteLine($"Pupil {name} is writing");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"Pupil {name} is relaxing");
        }
            
    }
} 
