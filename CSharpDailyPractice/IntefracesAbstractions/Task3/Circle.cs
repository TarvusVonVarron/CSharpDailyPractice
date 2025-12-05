using System;

namespace IntefracesAbstractions.Task3
{
    public class Circle : Shape, IResizable
    {
        public double Radius { get; private set; }

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

        public void Resize(double factor)
        {
            if (factor <= 0)
                throw new ArgumentOutOfRangeException(nameof(factor), "Коэффициент должен быть > 0");

            Radius *= factor;
        }
    }
}
