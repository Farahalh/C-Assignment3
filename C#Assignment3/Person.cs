using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment3
{
    public class Person
    {
        private int _age;
        private string _fName;
        private string _lName;
        private double _height;
        private double _weight;

        public int Age 
        { 
            get 
            { return _age; } 
            set 
            { 
                if (_age > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0.");
                }
            } 
        }

        //Commenting out below as it needs a UI in ASP.NET
        //[Required(ErrorMessage = "This is a required field.")]
        //[Range(2,10, ErrorMessage = "Name must be between 2 and 10 letters.")]
        public string FName 
        { 
            get 
            { return _fName; } 
            set 
            {
                if (_fName.Length < 10)
                {
                    _fName = value;
                }

                else
                {
                Console.WriteLine("Name must be greater than 2.");
                }
            } 
        }
        public string LName 
        { 
            get 
            { return _lName; } 
            set 
            { 
                _lName = value; 
            } 
        }
        public double Height { get { return _height; } set { _height = value; } }
        public double Weight { get { return _weight; } set { _weight = value; } }

        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {FName} {LName}");
        }

        public void DisplayPersonAttributes()
        { 
            Console.WriteLine($"You are {Age} years, {Height}cm tall and weigh {Weight}kg."); 
        }
    }
}
