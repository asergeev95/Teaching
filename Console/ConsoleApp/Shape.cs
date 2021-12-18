namespace ConsoleApp
{
    public abstract class Shape
    {
        protected readonly int Length;

        public Shape(int length)
        {
            Length = length;
        }

        public abstract double GetSquare();
    }
}