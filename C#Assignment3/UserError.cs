using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment3
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage() 
        {
            return "You tried to use a numeric input in a text only field. This fired and error!";
        }
    }
}
