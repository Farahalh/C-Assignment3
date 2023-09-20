using System;
using System.Collections.Generic;
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

        public int Age { get { return _age; } set { _age = value; } }
        public string FName { get { return _fName; } set { _fName = value; } }
        public string LName { get { return _lName; } set { _lName = value; } }
        public double Height { get { return _height; } set { _height = value; } }
        public double Weight { get { return _weight; } set { _weight = value; } }
    }
}
