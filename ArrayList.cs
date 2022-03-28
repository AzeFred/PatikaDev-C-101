using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayList liste = new arrayList();
            liste.Add("Fred");
            liste.Add(2);
            liste.Add(true);

            Console.WriteLine(list[0]);

            foreach (var element in liste)
            {
                Console.WriteLine(element);
            }

            string[] colors = {"red","green","blue"};
            liste.AddRange(colors);

            list<int> integers = new list<int>() {1,2,3,4};
            liste.AddRange(integers);

            // Other methods
            liste.Sort();
            liste.BinarySearch(2);
            liste.Reverse();
            foreach (var element in liste)
            {
                Console.WriteLine(element);
            }
            liste.Clear();

        }
    }
}