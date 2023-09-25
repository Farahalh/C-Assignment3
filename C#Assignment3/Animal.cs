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

        public abstract int Age { get; set; }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }

    public class Horse : Animal
    {
        public string Color { get; set; }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Horse(string name, double weight, int age, string color)
            : base(name, weight, age)
        {
            Color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("Neigh!");
        }

        public override string Stats()
        {
            string baseStats = base.Stats();
            return $"{baseStats}, Color: {Color}";
        }
    }

    public class Dog : Animal
    {
        //Implement all properties from abstract class animals, bcs it´s an abstract class
        public string Breed { get; set; }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Dog(string name, double weight, int age, string breed)
            : base(name, weight, age)
        {
            Breed = breed;
        }

        public override string Stats()
        {
            string baseStats = base.Stats();
            return $"{baseStats}, Breed: {Breed}";
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof!");
        }

        public string NewMethod()
        {
            return "This is a new method in the Dog class.";
        }
        //3.3 13. -
        //3.3 17. F. N oaccess to the list Animals
    }

    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

    public class Wolf : Animal
    {
        public string PackName { get; set; }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

    public class Pelican : Bird
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

    public class Flamingo : Bird
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

    public class Swan : Bird
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

    public class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("I am a Wolfman!");
        }

        public Wolfman(string name, double weight, int age, string packName)
        : base(name, weight, age, packName)
        {
            Console.WriteLine("I sound like a human!");
        }

        //3.2 13. F. In Bird class
        //3.2 14. F. In Animal class
    }
    }