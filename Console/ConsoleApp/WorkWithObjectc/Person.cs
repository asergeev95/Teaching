using System;

namespace ConsoleApp.WorkWithObjectc
{
    public class Person
    {
        public string Password { get;  }
        public DateTime BirthDay { get; set; } //автоматическое свойство
        public string Name { get; set; }
        public Person()
        {
        }
        
        public Person(string password)
        {
            Password = password;
        }

        public Person(string password, string name)
        {
            Password = password;
            Name = name;
        }

        public void AddAge(int numberOfYears)
        {
            BirthDay = BirthDay.AddYears(numberOfYears);
        }
        
        public void AddAge(int numberOfYears, int numberOfDays)
        {
            BirthDay = BirthDay.AddYears(numberOfYears).AddDays(numberOfDays);
        }

        public override string ToString()
        {
            return $"Hi there. My name is {Name}.I'm from {BirthDay.Year}";
        }
    }
}