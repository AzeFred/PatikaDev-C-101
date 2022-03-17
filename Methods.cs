using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            int sonuc = Topla(a,b);

            Console.WriteLine(sonuc);

            static int Topla(int int1, int int2)
            {
                return (int1 + int2);
            }

            Methods ornek = new Methods();
            ornek.PrintToScreen(sonuc.ToString());
            int sonuc2 = ornek.IncreaseAndSum(a,b);
        }
    }

    class Methods
    {
        public void PrintToScreen(string data)
        {
            Console.WriteLine(data);
        }

        public int IncreaseAndSum(int int1, int int2)
        {
            int1 += 1;
            int2 += 1;
            return (int1 + int2);
        }
    }
}