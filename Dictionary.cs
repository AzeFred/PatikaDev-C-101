using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> users = new Dictionary<int,string>();
            users.Add(10,"Fred");
            users.Add(12,"John");
            
            Console.WriteLine(users[12]);
            foreach (var item in users)
            {
                Console.WriteLine([item]);
            }
            Console.WriteLine(users.Count);
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Fred"));
            Console.WriteLine(users.Remove(10));
            Console.WriteLine(users.Keys);
            Console.WriteLine(users.Values);
        }
    }
}