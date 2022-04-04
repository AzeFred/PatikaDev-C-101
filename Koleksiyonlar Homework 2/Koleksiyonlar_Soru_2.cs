using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining arrays
            int[] inputArray = new int[20];
            int[] minArray = new int[3];
            int[] maxArray = new int[3];
            
            //Getting input
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            //Writing input to min and max arrays
            Array.Sort(inputArray);
            for (int i = 0; i < 3; i++)
            {
                minArray[i] = inputArray[i];
            }

            Array.Reverse(inputArray);
            for (int i = 0; i < 3; i++)
            {
                maxArray[i] = inputArray[i];
            }
            
            //Calculating sum of arrays for average
            int sumMin = 0;
            int sumMax = 0;
            
            foreach (int element in minArray)
            {
                sumMin += element;
            }
            
            foreach (int element in maxArray)
            {
                sumMax += element;
            }

            //Printing averages and their sum
            Console.WriteLine("Average of minimum array: " + sumMin / minArray.Length);
            Console.WriteLine("Average of maximum array: " + sumMax / maxArray.Length);
            Console.WriteLine("Sum of averages of two arrays: " + (sumMin / minArray.Length + sumMax / maxArray.Length));
        }
    }
}
