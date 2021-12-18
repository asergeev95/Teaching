using System;

namespace ConsoleApp.WorkWithObjectc
{
    public class Circle : Shape
    {
        public Circle(double length) : base(length)
        {
        }

        public override double CalculateSquare()
        {
            return Math.PI * Length * Length;
        }
    }
}