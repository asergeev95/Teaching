namespace ConsoleApp.WorkWithObjectc
{
    public class Square : Shape
    {
        public Square(double length) : base(length)
        {
        }

        public override double CalculateSquare()
        {
            return Length * Length;
        }
    }
}