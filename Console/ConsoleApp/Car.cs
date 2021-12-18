using System;

namespace ConsoleApp
{
    public class Car
    {
        protected readonly int Hp;
        protected double CurrentSpeed;
        
        public Car()
        {
            CurrentSpeed = 0;
        }
        
        //перегрузка конструкторов
        public Car(int hp)
        {
            Hp = hp;
            CurrentSpeed = 0;
        }

        public virtual void Accelerate(double additionalSpeed)
        {
            CurrentSpeed += additionalSpeed;
        }

        public void DisplayCurrentSpeed()
        {
            Console.WriteLine($"Current speed is {CurrentSpeed}");
        }
    }
}