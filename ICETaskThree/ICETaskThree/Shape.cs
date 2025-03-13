using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICETaskThree
{
    class Shape
    {
        //Create Name Property
        public string Name { get; set; }
    
        //Create Constructor
        public Shape (string name)
        {
            Name = name;
        }

        //Create Virtual Display Method
        public virtual void Display()
        {
            Console.WriteLine("This Method will be Changed");
        }
    }
}
