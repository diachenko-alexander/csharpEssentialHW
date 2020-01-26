using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("To edit document use PRO Version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("To save document use PRO Version");

        }
    }
}
