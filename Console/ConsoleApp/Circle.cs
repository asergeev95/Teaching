using System;

namespace ConsoleApp
{
    public class Circle : Shape
    {
        public Circle(int length) : base(length)
        {
        }

        public override double GetSquare()
        {
            return Math.PI * Length * Length;
        }
    }
}