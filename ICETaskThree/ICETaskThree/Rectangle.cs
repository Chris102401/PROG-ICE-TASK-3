using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICETaskThree
{
    class Rectangle : Shape, ICalculateArea
    {
        //Create two properties in Rectangle - Length and Width
        public int Length { get; set; }

        public int Width { get; set; }

        //Create a Constructor
        public Rectangle(string name, int length, int width) : base (name)
        {
            Length = length;

            Width = width;
        }

        //Create CalculateArea() Method
        public void CalculateArea()
        {
            Console.WriteLine($"Area of Rectangle: {(Length * Width)} units^2");
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle Details: \nName: {Name} \nLength: {Length} \nWidth: {Width}");
        }

    }
}
