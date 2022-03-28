using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Worker Number:  {0}", Worker.WorkerNumber);
            Worker worker1 = new Worker("Fred","Musavi","Development");
            Console.WorkerNumber("Worker Number:  {0}", Worker.WorkerNumber);
        }
    }

    class Worker
    {
        private static int workerNumber;
        public static int WorkerNumber
        {
            get => workerNumber;
        }

        private string Name;
        private string Surname;
        private string Department;

        public Worker(string name, string surname, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            workerNumber ++;
        }

        static Worker()
        {
            workerNumber = 0;
        }
    }

    static class Operations
    {
        public static long SumUp(int int1, int int2)
        {
            return int1 + int2;
        }
    }
}