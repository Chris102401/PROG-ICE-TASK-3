namespace ICETaskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle("Ralph", 12, 4);
            r.Display();
            r.CalculateArea();

            Circle c = new Circle("Chloe", 6);
            c.Display();
            c.CalculateArea();

            Console.ReadKey();
        }
    }
}
