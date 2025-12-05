using System;

namespace IntefracesAbstractions.Task2
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width), "Ширина должна быть > 0");
            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "Высота должна быть > 0");

            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Прямоугольник ({Width} x {Height}) имеет площадь {Area():F2}");
        }
    }
}
