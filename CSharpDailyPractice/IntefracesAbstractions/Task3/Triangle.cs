using System;

namespace IntefracesAbstractions.Task3
{
    public class Triangle : Shape
    {
        public double BaseLength { get; }
        public double Height { get; }

        public Triangle(double baseLength, double height)
        {
            if (baseLength <= 0)
                throw new ArgumentOutOfRangeException(nameof(baseLength), "Основание должно быть > 0");
            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "Высота должна быть > 0");

            BaseLength = baseLength;
            Height = height;
        }

        public override double Area()
        {
            return 0.5 * BaseLength * Height;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Треугольник (основание = {BaseLength}, высота = {Height}) имеет площадь {Area():F2}");
        }
    }
}
