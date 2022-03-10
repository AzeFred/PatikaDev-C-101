using System;

namespace Conversions
{
    class  Program
    {
        public void Main(string[] args)
        {
            //Implicit Conversions
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Farid";
            char f = "g"
            object g = e+f+d;
            Console.WriteLine("g: " + g);

            //Explicit Conversions
            int x = 4;
            byte y = (byte) x;
            Console.WriteLine("y: " + y);

            float w = 19.45f;
            byte z = (byte) w;
            Console.WriteLine("z: " + z);

            int dd = 54;
            string ss = dd.ToString();
            Console.WriteLine("ss: " + ss);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            string s1 = "10", s2 = "20";
            i1 = Convert.ToInt32(s1);
            i2 = Convert.ToInt32(s2);
            Console.WriteLine(i1+i2);

            string m1 = "12", m2 = "23.5f"
            int rakam = Int32.Parse(m1);
            double rakam2 = Double.Parse(m2);
            Console.WriteLine(rakam);
            Console.WriteLine(rakam2);



        }
    }
}