using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        public static ListNode CreateList(ListNode list, int n)
        {
            if (n > 0)
            {
                list.Next = new ListNode()
                {
                    Value = 5 - n
                };
                CreateList(list.Next, n - 1);
            }

            return list;
        }

        static void Main(string[] args)
        {
            // var car = new Car();
            // car.DisplayCurrentSpeed();
            // car.Accelerate(10);
            // car.DisplayCurrentSpeed();
            // car.Accelerate(10);
            // car.DisplayCurrentSpeed();
            //
            // Console.WriteLine("=================");
            // var raceCar = new RaceCar(100);
            // raceCar.DisplayCurrentSpeed();
            // raceCar.Accelerate(10);
            // raceCar.DisplayCurrentSpeed();
            // raceCar.Accelerate(10);
            // raceCar.DisplayCurrentSpeed();

            // var shapes = new List<Shape>();
            // shapes.Add(new Circle(3));
            // shapes.Add(new Square(2));
            // shapes.Add(new Square(5));
            // foreach (var shape in shapes)
            // {
            //     Console.WriteLine($"Square is {shape.GetSquare()}");
            // }

            //50, 40, 27, 17, 6, 4
            //35, 30, 29, 15, 5, 3, 1, 0
            //50, 40, 35, 30, 29, 27, 17, 15, 6, 5, 4, 3, 1, 0
            var n = 5;
            //var list = CreateList(new ListNode(), n);
            var list = new ListNode(1);
            list.Add(2, 3, 4);
        }
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int value)
        {
            Value = value;
        }

        public void Add(params int[] values)
        {
            foreach (var value in values)
            {
                if (Next == null)
                {
                    var node = new ListNode(value);
                    Next = node;
                }
                else
                {
                    var node = new ListNode(value);
                    Next.Next = node;
                }
            }
        }
    }
}