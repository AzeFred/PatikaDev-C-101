using System;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Angiosperms angiosperm = new Angiosperms();
            angiosperm.Excretion();
            angiosperm.Nutrition();
            angiosperm.Respiration();
            angiosperm.Photosynthesis();
            angiosperm.Seed();

            Birds seagull = new Birds();
            seagull.Nutrition();
            seagull.Fly();
        }

    }

    class Organisms
    {
        public void Nutrition()
        {
            Console.WriteLine("Nutrition");
        }

        public void Respiration()
        {
            Console.WriteLine("Respiration");
        }

        public void Excretion()
        {
            Console.WriteLine("Excretion");
        }
    }

    class Plants : Organisms
    {
        public void Photosynthesis()
        {
            Console.WriteLine("Photosynthesis");
        }
    }

    class Animals : Organisms
    {
        public void Adaptation()
        {
            Console.WriteLine("Adaptation");
        }
    }

    class Gymnosperms : Plants
    {
        public void Seedless()
        {
            Console.WriteLine("Seedless");
        }
    }

    class Angiosperms : Plants
    {
        public Angiosperms()
        {
            base.Nutrition();
            base.Excretion();
            base.Respiration();
        }
        public void Seed()
        {
            Console.WriteLine("Seed");
        }
    }

    class Reptiles : Animals
    {
        public void Skin()
        {
            Console.WriteLine("Skin");
        }
    }

    class Birds : Animals
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}