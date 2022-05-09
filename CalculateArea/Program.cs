using CalculateArea.Figures.Primitives;
using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine($"Circle area: {circle.Area}");

            Triangle triangle1 = new Triangle(12, 13, 10);
            Triangle triangle3 = new Triangle(15, 12, 9);

            List<Triangle> triangles = new List<Triangle> { triangle1, triangle3 };

            foreach(Triangle triangle in triangles)
            {
                Console.WriteLine($"Triangle area: {triangle.Area}, is rectangular: {triangle.IsRectangular}");

            }
        }
    }
}