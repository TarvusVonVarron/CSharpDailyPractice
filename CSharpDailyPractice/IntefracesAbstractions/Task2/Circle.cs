using System;

namespace IntefracesAbstractions.Task2
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Радиус должен быть > 0");

            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Окружность (R = {Radius}) имеет площадь {Area():F2}");
        }
    }
}
