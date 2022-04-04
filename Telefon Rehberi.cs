using System;
using System.Collections.Generic;

namespace Telefon_Rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> contacts = new Dictionary<string, int>();
            contacts.Add("Cristiano Ronaldo", 5556);
            contacts.Add("Lionel Messi", 4533);
            contacts.Add("Manuel Neuer", 5696);
            contacts.Add("Zlatan Ibra", 9987);
            contacts.Add("Zinedine Zidane", 1122);

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                AddNumber();
            }
            else if (input == 2)
            {
                DeleteNumber();
            }
            else if (input == 3)
            {
                UpdateNumber();
            }
            else if (input == 4)
            {
                ListContacts();
            }
            else if (input == 5)
            {
                SearchContacts();
            }

            void AddNumber()
            {
                Console.WriteLine("Lutfen isim giriniz: ");
                string newName = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz: ");
                string newSurname = Console.ReadLine();
                Console.WriteLine("Lütfen telefon numarası giriniz: ");
                int newNumber = Convert.ToInt32(Console.ReadLine());
                contacts.Add(newName + " " + newSurname, newNumber);
            }

            void DeleteNumber()
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string input = Console.ReadLine();
                if (contacts.ContainsKey(input))
                {
                    foreach (var key in contacts.Keys)
                    {
                        if (key.Contains(input))
                        {
                            Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", key);
                            string newInput = Console.ReadLine();
                            if (newInput == "y")
                            {
                                contacts.Remove(key);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için    : (1)");
                    Console.WriteLine("* Yeniden denemek için              : (2)");
                    int newInput = Convert.ToInt32(Console.ReadLine());
                    if (newInput == 2)
                    {
                        DeleteNumber();
                    }
                    else { return; }
                }
            }

            void UpdateNumber()
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string input = Console.ReadLine();
                if (contacts.ContainsKey(input))
                {
                    foreach (var key in contacts.Keys)
                    {
                        if (key.Contains(input))
                        {
                            int number = Convert.ToInt32(Console.ReadLine());
                            contacts[key] = number;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Guncellemeyi sonlandırmak için    : (1)");
                    Console.WriteLine("* Yeniden denemek için              : (2)");
                    int newInput = Convert.ToInt32(Console.ReadLine());
                    if (newInput == 2)
                    {
                        UpdateNumber();
                    }
                    else { return; }
                }
            }

            void ListContacts()
            {
                foreach (var element in contacts)
                {
                    Console.WriteLine("Isim ve soyisim: " + element.Key);
                    Console.WriteLine("Telefon Numarasi: " + element.Value.ToString());
                }
            }

            void SearchContacts()
            {
                Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("**********************************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                Dictionary<string, int> newDictionary = new Dictionary<string, int>();
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    string newInput = Console.ReadLine();
                    if (contacts.ContainsKey(newInput))
                    {
                        foreach (var element in contacts.Keys)
                        {
                            if (element.Contains(newInput))
                            {
                                newDictionary.Add(element, contacts[element]);
                            }
                        }
                    }
                }
                else if (input == 2)
                {
                    int newInput = Convert.ToInt32(Console.ReadLine());
                    if (contacts.ContainsValue(newInput))
                    {
                        foreach(var element in contacts.Keys)
                        {
                            if (contacts[element] == newInput)
                            {
                                newDictionary.Add(element, contacts[element]);
                            }
                        }
                    }
                }
                foreach (var element in newDictionary)
                {
                    Console.WriteLine("Isim ve soyisim: " + element.Key);
                    Console.WriteLine("Telefon Numarasi: " + element.Value.ToString());
                }
            }
        }
    }
}
