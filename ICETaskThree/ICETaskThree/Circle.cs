using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICETaskThree
{
    class Circle : Shape, ICalculateArea
    {
        //Create Property - Radius
        public int Radius { get; set; }

        //Create a Constructor
        public Circle(string name, int radius) : base(name)
        {
            Radius = radius;
        }

        //Create CalculateCircleArea() Method
        public void CalculateArea()
        {
            double PI = Math.PI;

            Console.WriteLine($"Area of Circle: {(PI * (Radius*Radius)):F2} units^2");
        }

        public override void Display()
        {
            Console.WriteLine($"Circle Details: \nName: {Name} \nPI: {Math.PI:F2} \nRadius: {Radius}");
        }
    }
}
