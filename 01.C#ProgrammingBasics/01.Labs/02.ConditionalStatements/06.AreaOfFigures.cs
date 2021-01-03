using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            switch (figureType)
            {
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    double squareArea = Math.Pow(squareSide, 2);

                    Console.WriteLine($"{squareArea:F3}");
                    break;
                case "rectangle":
                    double rectangleFirstSide = double.Parse(Console.ReadLine());
                    double rectangleSecondSide = double.Parse(Console.ReadLine());
                    double rectangleArea = rectangleFirstSide * rectangleSecondSide;

                    Console.WriteLine($"{rectangleArea:F3}");
                    break;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    double circleArea = Math.PI * Math.Pow(circleRadius, 2);

                    Console.WriteLine($"{circleArea:F3}");
                    break;
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    double triangleArea = (triangleSide * triangleHeight) / 2;

                    Console.WriteLine($"{triangleArea:F3}");
                    break;
                default:
                    break;
            }

        }
    }
}
