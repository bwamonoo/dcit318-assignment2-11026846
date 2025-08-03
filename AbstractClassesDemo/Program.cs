using System;

namespace AbstractClassesDemo
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Abstract Classes & Methods ---");

            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine("Circle Area: " + circle.GetArea().ToString("F2"));
            Console.WriteLine("Rectangle Area: " + rectangle.GetArea());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}