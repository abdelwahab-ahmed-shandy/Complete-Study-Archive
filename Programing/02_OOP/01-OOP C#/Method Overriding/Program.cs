/*
Method Overriding:

Create a parent class called Shape that contains a CalculateArea function that returns a constant.

Create subclasses like this:
Rectangle adds the Length and Width properties and overrides the CalculateArea function to calculate the area of ​​a rectangle.
Circle adds the Radius property and overrides the function to calculate the area of ​​a circle.
 */
namespace Method_Overriding
{
    class Shape
    {
        public double CalculateArea { get; set; }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
