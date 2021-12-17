using System;

namespace ConsoleApp.Models
{
    public class Car
    {
        protected readonly int _year;
        protected readonly string _model;
        protected int currentSpeed;
        
        public Car(int year, string model)
        {
            _year = year;
            _model = model;
            currentSpeed = 0;
        }

        public virtual void SpeedUp(int additionalSpeed)
        {
            currentSpeed += additionalSpeed;
        }

        public void DisplaySpeed()
        {
            Console.WriteLine($"Current speed is {currentSpeed}");
        }
    }

    public class RaceCar : Car
    {
        private readonly int _maxSpeed;

        public RaceCar(int year, string model, int maxSpeed) : base(year, model)
        {
            _maxSpeed = maxSpeed;
        }

        public override void SpeedUp(int additionalSpeed)
        {
            additionalSpeed =  (int)(additionalSpeed * Math.E);
            base.SpeedUp(additionalSpeed);
        }
    }
}