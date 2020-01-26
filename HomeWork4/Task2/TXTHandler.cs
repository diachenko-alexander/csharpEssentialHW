using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT Format");
        }
        public override void Create()
        {
            Console.WriteLine("Create TXT Format");
        }
        public override void Change()
        {
            Console.WriteLine("Change TXT Format");
        }
        public override void Save()
        {
            Console.WriteLine("Save TXT Format");
        }
    }
}
