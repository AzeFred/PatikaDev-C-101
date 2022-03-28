using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation
            Student student = new Student();
            student.Name = "Fred";
            student.Surname = "Musavi";
            student.Id = 192;
            student.Grade = 11;
            student.StudentInfo();

            student.GradeIncrease();
            student.StudentInfo();

            Student student1 = new Student("Deniz","Arda",234,10)
            student1.GradeDecrease();
            student1.StudentInfo();
        }
    }

    class Student
    {
        private string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        private string surname;
        public string Surname
        {
            get => surname; set => surname = value;
        }

        private int id;
        public int Id 
        {
            get => id; set => id = value;
        }

        private int grade;
        public int Grade 
        { 
            get => grade; 
            set 
            { 
                if (grade <= 1)
                {
                    Console.WriteLine("Grade cannot be below 1!");
                    grade = 1;
                }
                else {grade = value;}
            }
        }

        public Student(){}

        public Student(string name, string surname, int id, int grade)
        {
            Name = name;
            Surname = surname;
            Id = id;
            Grade = grade;
        }

        public void StudentInfo()
        {
            Console.WriteLine("Name      :{0}",this.Name);
            Console.WriteLine("Surname      :{0}",this.Surname);
            Console.WriteLine("ID      :{0}",this.Id);
            Console.WriteLine("Grade      :{0}",this.Grade);
        }

        public void GradeIncrease()
        {
            this.Grade += 1;
        }

        public void GradeDecrease()
        {
            this.Grade -= 1;
        }
    }
}