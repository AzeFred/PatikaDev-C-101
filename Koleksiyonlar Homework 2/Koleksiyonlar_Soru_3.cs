using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining input and collections
            string input = Console.ReadLine();
            List<char> inputVowels = new List<char>();
            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'u', 'ö','ü'};

            //Adding vowels from input to list
            foreach (var element in input)
            {
                foreach (var letter in vowels)
                {
                    if (element == letter)
                    {
                        inputVowels.Add(element);
                    }
                }
            }
            
            //Printing vowels in the input
            foreach(var letter in inputVowels)
            {
                Console.Write(letter + " ");
            }
        }
    }
}
