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
            
            Worker worker1 = new Worker("Fred","Musavi",23443456,"Development");
            worker1.WorkerInfo();

            Worker worker2 = new Worker("Ziko","Urko");
            worker2.WorkerInfo();

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

       public Worker(string ad, string soyad, int id, string department)
       {
           this.Ad = ad;
           this.Soyad = soyad;
           this.Id = id;
           this.Department = department;
       }

       public Worker(string ad, string soyad)
       {
           this.Ad = ad;
           this.Soyad = soyad;
       }
   }
}