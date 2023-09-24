using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment3
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract double Weight { get; set; }

        public int Age { get; set; }

        public abstract void DoSound();

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }

    public abstract class Horse : Animal
    {
        public string Color { get; set; }

        public Horse(string name, double weight, int age, string color)
            : base(name, weight, age)
        {
            Color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("Neigh!");
        }
    }

    public abstract class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, double weight, int age, string breed)
            : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public abstract class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int nrOfSpikes)
            : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squeak!");
        }
    }

    public abstract class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan)
            : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp chirp!");
        }
    }

    public abstract class Wolf : Animal
    {
        public string PackName { get; set; }

        public Wolf(string name, double weight, int age, string packName)
            : base(name, weight, age)
        {
            PackName = packName;
        }

        public override void DoSound()
        {
            Console.WriteLine("Howl!");
        }
    }

    public abstract class Pelican : Bird
    {
        public bool CanDive { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, bool canDive)
            : base(name, weight, age, wingSpan)
        {
            CanDive = canDive;
        }

        public override void DoSound()
        {
            Console.WriteLine("Flap flap!");
        }
    }

    public abstract class Flamingo : Bird
    {
        public string Color { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, string color)
            : base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squawk!");
        }
    }

    public abstract class Swan : Bird
    {
        public bool IsElegant { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, bool isElegant)
            : base(name, weight, age, wingSpan)
        {
            IsElegant = isElegant;
        }

        public abstract class Swan : Bird
        {
            public bool IsElegant { get; set; }

            public Swan(string name, double weight, int age, double wingSpan, bool isElegant)
                : base(name, weight, age, wingSpan)
            {
                IsElegant = isElegant;
            }

            public override void DoSound()
            {
                Console.WriteLine("Honk!");
            }
        }

        public interface IPerson
        {
            void Talk();
        }

    }
}