using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp hosgeldiniz!";
            string degisken2 = "Csharp";
            Console.WriteLine(degisken.Length);
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            Console.WriteLine(string.Concat("Merhaba ", degisken));

            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(string.Compare(degisken, degisken2, true));
            Console.WriteLine(string.Compare(degisken, degisken2, false));

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            Console.WriteLine(degisken.IndexOf("Csharp"));
            Console.WriteLine(degisken.IndexOf("Fred")); //-1 if no find
            Console.WriteLine(degisken.LastIndexOf("i"));

            Console.WriteLine(degisken.Insert(0, "Merhaba! "));
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'+'));
            Console.WriteLine(degisken.PadRight(35) + degisken2);
            Console.WriteLine(degisken.PadRight(35, '*') + degisken2);

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(degisken.Length - 1, 1));

            Console.WriteLine(degisken.Replace("Csharp", "C#"));

            Console.WriteLine(degisken.Split(" ") [1]);

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}
