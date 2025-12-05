using System;

namespace IntefracesAbstractions.Task3
{
    public class Rectangle : Shape, IResizable
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

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

        public void Resize(double factor)
        {
            if (factor <= 0)
                throw new ArgumentOutOfRangeException(nameof(factor), "Коэффициент должен быть > 0");

            Width *= factor;
            Height *= factor;
        }
    }
}
