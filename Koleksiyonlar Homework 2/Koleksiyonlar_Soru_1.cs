using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating arraylists
            ArrayList inputList = new ArrayList();
            ArrayList primeList = new ArrayList();
            ArrayList nonPrimeList = new ArrayList();

            //Catching negative numbers and non-numeric values
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Please enter a positive number");
                        break;
                    }
                    inputList.Add(number);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a positive number");
            }

            //Adding input to prime and non prime arraylists
            foreach (int number in inputList)
            {
                if (number == 1)
                {
                    nonPrimeList.Add(number);
                }
                else if (number == 2)
                {
                    primeList.Add(number);
                }
                else
                {
                    int primeNumber = 0;
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            primeNumber++;
                        }
                    }
                    if (primeNumber == 0)
                    {
                        primeList.Add(number);
                    }
                    else
                    {
                        nonPrimeList.Add(number);
                    }
                }
            }
            
            //Sorting arraylists from large number to smaller
            primeList.Sort();
            primeList.Reverse();
            nonPrimeList.Sort();
            nonPrimeList.Reverse();
            int sumPrime = 0;
            int sumNonPrime = 0;

            foreach (int element in primeList)
            {
                Console.Write(element + " ");
                sumPrime += element;
            }

            foreach (int element in nonPrimeList)
            {
                Console.Write(element + " ");
                sumNonPrime += element;
            }

            //Printing number of elements and average for each arraylist
            Console.WriteLine("Number of elements of prime list: " + primeList.Count);
            Console.WriteLine("Number of elements of nonprime list: " + nonPrimeList.Count);
            Console.WriteLine("Average of elements of prime list: " + sumPrime / primeList.Count);
            Console.WriteLine("Average of elements of nonprime list: " + sumNonPrime / nonPrimeList.Count);
        }
    }
}
