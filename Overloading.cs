using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            int outsayi;

            bool sonuc = Int.TryParse(sayi, out outsayi);
            if (sonuc)
            {
                Console.WriteLine("Basarili! " + sayi)
            }
            else { Console.WriteLine("Basarisiz :( ")}

            Methods instance = new Methods();
            instance.Topla(2,3,out int cevap);
            Console.WriteLine(cevap);

            // Overloading
            int smth = 999;
            instance.EkranaYazdir(smth);
            instance.EkranaYazdir("Farid","Musayev");
        }
    }

    class Methods
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string data)
        {
            Console.WriteLine(data);
        }

        public void EkranaYazdir(int data)
        {
            Console.WriteLine(data);
        }

        public void EkranaYazdir(string data1, string data2)
        {
            Console.WriteLine(data1 + data2);
        }
    }
}