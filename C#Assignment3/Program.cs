using System.ComponentModel;
using System.Globalization;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            {
                new NumericInputError();
                new TextInputError();
            }

            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }

            public class RandomErrorOne : UserError
        {
            public override string UEMessage()
            {
                return "Custom error message one!";
            }
        }

        public class RandomErrorTwo : UserError
        {
            public override string UEMessage()
            {
                return "Custom error message two!";
            }
        }

        public class RandomErrorThree : UserError
        {
            public override string UEMessage()
            {
                return "Custom error message three!";
            }
        }
    }
    }