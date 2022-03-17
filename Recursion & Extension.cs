using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive methods

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
            Islemler instance = new Islemler();
            int new_result = instance.Exponent(3,4)

            // Extension methods

            string ifade = "Farid Musayev";
            Console.WriteLine(ifade.CheckSpaces());
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
    }

    class Islemler
    {
        public int Exponent(int number, int power)
        {
            if (power < 2)
            {
                return number
            }
            else 
            {
                return Exponent(number,power-1) * number;
                //Exponent(3,4)
                //Exponent(3,3) * 3
                //Exponent(3,2) * 3 * 3
                //Exponent(3,1) * 3 * 3 * 3
            }
        }

        public static class Extension()
        {
            public static bool CheckSpaces(this string param)
            {
                return param.Contains(" ");
            }

            public static string RemoveWhiteSpaces(this string param)
            {
                
                string[] dizi = param.Split(" ");
                return string.Join("",dizi);
                
            }
        }
    }
}