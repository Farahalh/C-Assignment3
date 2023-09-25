using System.ComponentModel;
using System.Globalization;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using C_Assignment3;

namespace C_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("What is your first name?");
            person.FName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            person.LName = Console.ReadLine();
            person.DisplayFullName();

            Console.WriteLine("How old are you?");
            person.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your height?");
            person.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight?");
            person.Weight = int.Parse(Console.ReadLine());
            person.DisplayPersonAttributes();

            List<UserError> errors = new List<UserError>();
            //{ not needed 
                errors.Add(new NumericInputError());
                new TextInputError();
            //}

            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            List<Animal> Animals = new List<Animal>();

            Dog dog = new("Frodo", 12.5, 2, "Golden Retriever");
            Animals.Add(dog);

            Horse horse = new("Legolas", 450.5, 5, "Grey");
            Animals.Add(horse);

            //new Dog(){Name = "Frodo", Weight = 12.5, Age = 2, Breed = "Golden Retriever"};
            //new Horse(){Name = "Legolas", Weight = 450.5, Age = 5, Color = "Grey"};
            

            foreach (Animal animal in Animals)
            {
                string stats = animal.Stats();
                Console.WriteLine(animal.Stats());

                animal.DoSound();

                if(animal is IPerson) 
                {
                    ((IPerson)animal).Talk();
                }

                if(animal is Dog)
                {
                    Console.WriteLine(stats);
                }
            }

            List<Dog> dogs = new List<Dog>();
            {
                dogs.Add(new Dog());
                dogs.Add(new Horse());
                
            }

            //3.3 9 F. Because a horse is not a dog
            //3.3 10. F. List<Animal>
        }

        public abstract class RandomErrorOne : UserError
        {
            public override string UEMessage()
            {
                return "Custom error message one!";
            }
        }

        public abstract class RandomErrorTwo : UserError
        {
            public override string UEMessage()
            {
                return "Custom error message two!";
            }
        }

        public abstract class RandomErrorThree : UserError
        {
            public override string UEMessage()
            {
                return "Custom error message three!";
            }
        }
    }
    }