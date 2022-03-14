using System;

namespace Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {1,2,3,4,5,6,7};
            foreach (int index in sayiDizisi)
            {
                Console.WriteLine(index);
            }
            
            // Sort
            Array.Sort(sayiDizisi);
            foreach (int index in sayiDizisi)
            {
                Console.WriteLine(index);
            }

            //Clear
            Array.Clear(sayiDizisi,2,2);
            foreach (int index in sayiDizisi)
            {
                Console.WriteLine(index);
            }

            //Reverse
            Array.Reverse(sayiDizisi);
            foreach (int index in sayiDizisi)
            {
                Console.WriteLine(index);
            }
            
            //IndexOf
            Console.WriteLine(Array.IndexOf(sayiDizisi,7));

            //Resize
            Array.Resize<int>(ref sayiDizisi, 9);

        }
    }
}