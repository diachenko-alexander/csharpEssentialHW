using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML Format");
        }
        public override void Create()
        {
            Console.WriteLine("Create XML Format");
        }
        public override void Change()
        {
            Console.WriteLine("Change XML Format");
        }
        public override void Save()
        {
            Console.WriteLine("Save XML Format");
        }
    }
}
