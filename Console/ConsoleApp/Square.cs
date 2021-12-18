namespace ConsoleApp
{
    public class Square : Shape
    {
        public Square(int length) : base(length)
        {
        }

        public override double GetSquare()
        {
            return Length * Length;
        }
    }
}