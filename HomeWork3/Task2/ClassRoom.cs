using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        

        public ClassRoom(params Pupil [] pupils)
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                this.pupils[i] = pupils[i]; 
            }
            
        }

        public void HowClassStudy()
        {
            foreach (Pupil pupil in pupils)
            {
                if (pupil != null)
                {
                    pupil.Study();
                }
                
            }
        }

        public void HowClassRead()
        {
            foreach (Pupil pupil in pupils)
            {
                if (pupil != null)
                {
                    pupil.Read();
                }

            }
        }

        public void HowClassWrite()
        {
            foreach (Pupil pupil in pupils)
            {
                if (pupil != null)
                {
                    pupil.Write();
                }

            }
        }

        public void HowClassRest()
        {
            foreach (Pupil pupil in pupils)
            {
                if (pupil != null)
                {
                    pupil.Relax();
                }

            }
        }
    }
}
