using System;

namespace Enums
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Saturday);
            int temperature = 25;
            
            if (temperature => (int)Weather.Hot)
            {
                Console.WriteLine("Weather is hot!");
            }
            else
            {
                Console.WriteLine("You can go and play outside!");
            }
        }

    }

    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Weather
    {
        Cold = 5,
        Normal = 20,
        Hot = 25
    }
}