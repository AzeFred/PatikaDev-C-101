using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculation Operators
            int y = 3;
            int x = 5;
            y += 2;
            x /= 5;

            Console.WriteLine(x);
            Console.WriteLine(y);

            // Logical Operators
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            else if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }
            else if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            // Relation Operators
            // >, <, ==, <=, >=

            bool result = x > y;
            Console.WriteLine(result);

            // Arithmetic Operators

            bool new_result = x % y;
            Console.WriteLine(new_result);
        }
    }
}