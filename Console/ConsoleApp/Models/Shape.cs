using System;

namespace ConsoleApp.Models
{
    public abstract class Shape
    {
        protected readonly float _length;

        protected Shape(float length)
        {
            _length = length;
        }

        public abstract float CalculateSquare();

        public void DoSmth()
        {
            
        }
    }

    public class Square : Shape
    {
        public Square(float length) : base(length)
        {
        }

        public override float CalculateSquare()
        {
            return _length * _length;
        }
    }

    public class Circle : Shape
    {
        public Circle(float length) : base(length)
        {
        }

        public override float CalculateSquare()
        {
            return (float)(Math.PI * _length * _length);
        }
    }
    
}