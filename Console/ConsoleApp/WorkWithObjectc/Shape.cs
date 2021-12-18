namespace ConsoleApp.WorkWithObjectc
{
    public abstract class Shape
    {
        protected readonly double Length;

        public Shape(double length)
        {
            Length = length;
        }
        public abstract double CalculateSquare();
    }
}