using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<type> name;
            // Comes from System.Collections.Generic
            List<int> integers = new List<int>();
            integers.Add(5);
            integers.Add(92);
            integers.Add(8);

            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");

            Console.WriteLine(colors.Count);
            Console.WriteLine(integers.Count);

            foreach (int integer in integers)
            {
                Console.WriteLine(integer);
            }

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            integers.ForEach(integer => Console.WriteLine(integer));
            colors.ForEach(color => Console.WriteLine(color));

            integers.Remove(5);
            colors.Remove("Green");
            integers.RemoveAt(0);

            if (integers.Contains(92))
            {
                Console.WriteLine("We found 92!");
            }
            Console.WriteLine(colors.BinarySearch("Blue"));

            string[] animals = { "Cat", "Dog", "Snake" };
            List<string> animalsList = new List<string>(animals);

            animalsList.Clear();
        }
    }
}
