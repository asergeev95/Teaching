using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        //есть два односвязных списка размер n и m соответветственно. n, m - разные. 
        //каждый список упорядочен по убыванию 
        //построить из этих двух списков новый список, который так же будет упорядочен по убыванию.
        // 50, 40, 18, 7, 3
        // 20, 15, 11
        // 50, 40, 20, 18, 15, 11, 7, 3 
        private static ListNode CreateList(ListNode list, int n)
        {
            if (n > 0)
            {
                list.Next = new ListNode
                {
                    Value = 5 - n
                };
                CreateList(list.Next, n - 1);
            }

            return list;
        }

        public static void DisplayList(ListNode list)
        {
            Console.Write($"{list.Value}  ");
            if (list.Next != null)
            {
                DisplayList(list.Next);
            }
        }
        static void Main(string[] args)
        {
            var n = 5;
            var list = new ListNode
            {
                Value = 0
            };
            list = CreateList(list, n-1);
            DisplayList(list);
        }
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }
    }
}