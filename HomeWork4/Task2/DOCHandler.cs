using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DOCHandler : AbstractHandler
    {
        public override void Open() 
        {
            Console.WriteLine("Open Doc Format");
        }
        public override void Create() 
        {
            Console.WriteLine("Create Doc Format");
        }
        public override void Change()
        {
            Console.WriteLine("Change Doc Format");
        }
        public override void Save()
        {
            Console.WriteLine("Save Doc Format");
        }
    }
}
