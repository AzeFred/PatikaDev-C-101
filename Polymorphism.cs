using System;

namespace Polymorphism
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

        public virtual Sensitivity()
        {
            Console.WriteLine("Sensitivity");
        }
    }

    class Plants : Organisms
    {
        public void Photosynthesis()
        {
            Console.WriteLine("Photosynthesis");
        }

        public override void Sensitivity()
        {
            base.Sensitivity();
            Console.WriteLine("Plants are sensitive");
        }
    }

    class Animals : Organisms
    {
        public void Adaptation()
        {
            Console.WriteLine("Adaptation");
        }

        public override void Sensitivity()
        {
            base.Sensitivity();
            Console.WriteLine("Animals are sensitive");
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
            base.Sensitivity();
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

    public sealed class Bacteria
    {
        
    }
}