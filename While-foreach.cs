using System;

namespace While_foreach0
{
 class Program
 {
    static void Main(string[] args)
    {
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while(sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }
        Console.WriteLine(toplam/sayi);

        char character = "a";
        while (character <= "z")
        {
            Console.WriteLine(character);
            character++;
        }

        string[] arabalar = {"Ford", "BMW", "Toyota", "Nissan"};
        foreach (string araba in arabalar)
        {
            Console.WriteLine(araba);
        }

    }
 }   
}