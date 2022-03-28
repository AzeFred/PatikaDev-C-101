using System;

namespace Sinif
{
   class Program
   {
       static void Main(string[] args)
       {
           /* class nameOfClass
           {
               public/private type property;
               public/private returnType Method(inputType input)
               {
                   Commands
               }

            // Erisim belirtecleri
            * public -> reachable everywhere
            * private -> reachable only in class
            * internal -> reachable only in the project
            * protected -> reachable only in class and referenced class*/
            Worker worker1 = new Worker();
            worker1.Ad = "Fred";
            worker1.Soyad = "Musavi";
            worker1.Id = 23443456;
            worker1.Department = "Development";
            worker1.WorkerInfo();

       }
   }

   class Worker
   {
       public string Ad;

       public string Soyad;

       public int Id;

       public string Department;

       public void WorkerInfo()
       {
           Console.WriteLine("Worker Name: " + Ad);
           Console.WriteLine("Worker Surname: " + Soyad);
           Console.WriteLine("Worker ID: " + Id);
           Console.WriteLine("Worker Department: " + Department);
       }
   }
}