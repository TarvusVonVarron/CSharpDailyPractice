using System;

namespace IntefracesAbstractions.Task3
{
    public abstract class Shape
    {
        public abstract double Area();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name} с площадью {Area():F2}");
        }
    }
}
