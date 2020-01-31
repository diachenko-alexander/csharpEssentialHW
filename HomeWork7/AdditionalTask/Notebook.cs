using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    struct Notebook
    {
        string model;
        string manufakturer;
        double price;

        public Notebook(string model, string manufakturer, double price)
        {
            this.model = model;
            this.manufakturer = manufakturer;
            this.price = price;
        }

        public Notebook(string model)
           : this (model, "unknown", 0)
        {
                
        }

        public Notebook(string model, string manufakturer)
            : this (model, manufakturer, 0)
        {

        }

        public string Model { get { return model; } }
        public string Manufakturer { get { return manufakturer; } }
        public double Price { get { return price; } }

        public void Show()
        {
            Console.WriteLine($"Model: {Model}\nManufakturer: {Manufakturer}\nPrice: {Price}");
        }
    }
}
