using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment3
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage() 
        {
            return "You tried to use a numeric input in a text only field. This fired and error!";
        }
    }

    public class TextInputError : UserError
    { public override string UEMessage() 
        {
            return "You tried to use a text input in a numeric only field. This fired and error!";
        } 
    }
}
