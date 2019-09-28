using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            foreach (var x in Enumerable.Range(1, 5))
            {
                list.Add(x);
            }

            Console.WriteLine("List:");

            foreach (var x in list)
            {
                Console.WriteLine(x);
            }

            Queue<int> queue = new Queue<int>();

            foreach (var x in Enumerable.Range(1, 5))
            {
                queue.Enqueue(x);
            }

            Console.WriteLine("Queue:");

            foreach (var x in queue)
            {
                Console.WriteLine(x);
            }

            Stack<int> stack = new Stack<int>();

            foreach (var x in Enumerable.Range(1, 5))
            {
                stack.Push(x);
            }

            Console.WriteLine("Stack:");

            foreach (var x in stack)
            {
                Console.WriteLine(x);
            }

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            string a = "A";

            for (int i = 0; i < 5; i++)
            {
                dictionary.Add(i, a);
                a += "A";
            }

            Console.WriteLine("Dicitonary:");

            foreach (var x in dictionary)
            {
                Console.WriteLine(x);
            }

            SortedList<int, int> sortedList = new SortedList<int, int>();

            for (int i = 0; i < 5; i++)
            {
                sortedList.Add(i, (i * 2));
            }

            Console.WriteLine("Sorted List:");

            foreach (var x in sortedList)
            {
                Console.WriteLine(x);
            }

            HashSet<int> hashSet = new HashSet<int>();

            foreach (var x in Enumerable.Range(1, 5))
            {
                hashSet.Add(x);
            }

            Console.WriteLine("Hash Set:");

            foreach (var x in hashSet)
            {
                Console.WriteLine(x);
            }
        }
    }
}

