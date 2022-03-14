using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Kopek","Kus","Maymun"};

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";
            Console.WriteLine(renkler[0]);

            Console.WriteLine(hayvanlar[0]);

            dizi[3] = 10;
            Console.WriteLine(dizi[3]);

            Console.Write("Lutfen dizi uzunlugu giriniz! ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 1; i < diziUzunlugu; i++)
            {
                Console.Write("Lutfen {0}. sayini giriniz! " + i);
                sayiDizisi[i-1] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (int index in sayiDizisi)
            {
                toplam += index;
            }
            Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);
        }
    }
}