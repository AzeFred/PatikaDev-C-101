using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi girin: ")
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayi: " + sayi);
        }
    }
}