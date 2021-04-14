using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Shunting_Yard_Ver_1
{
    /// <summary>
    /// Enum contains operators and its code in integer
    /// </summary>
    public enum OperatorType
    {
        //Add operator
        Add,

        //minus operator
        Minus,

        //Multiply operator
        Multiply,

        //Divide operator
        Divide,

        //open bracket
        OpenBracket,

        //Close bracket
        CloseBracket
    }
}
