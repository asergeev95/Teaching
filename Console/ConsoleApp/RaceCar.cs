namespace ConsoleApp
{
    public class RaceCar : Car
    {
        public RaceCar() : base()
        {
        }
        public RaceCar(int hp) : base(hp) 
        {
        }

        public override void Accelerate(double additionalSpeed)
        {
            additionalSpeed = (0.1 * Hp) * additionalSpeed;
            CurrentSpeed += additionalSpeed + 50;
        }
    }
}