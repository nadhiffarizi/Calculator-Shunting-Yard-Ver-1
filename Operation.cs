using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Shunting_Yard_Ver_1
{
    class Operation
    {
        #region Constructor

        /// <summary>
        /// constructor, when object created groupednumbers properties equals to empty string
        /// </summary>
        public Operation()
        {
            GroupedNumbers = "";
            OpenBracketCount = 0;
            ClosedBracketCount = 0;
            OpenBracketPrecedence = 0;
            ClosedBracketPrecedence = 0;

        }


        #endregion

        #region properties

        /// <summary>
        /// Identified operator other than brackets 
        /// store integer how many operatir other than brackets in equation
        /// </summary>
        public int NoBracketCount { get; set; }

        /// <summary>
        /// Identified brackets '('
        /// store integer how many open bracket in equation
        /// </summary>
        public int OpenBracketCount { get; set; }

        /// <summary>
        /// Set the precedence of open bracket, for this operator, precedence is dynamically changed
        /// </summary>
        public int OpenBracketPrecedence { get; set; }


        /// <summary>
        /// Identified brackets ')'
        /// store integer how many close bracket in equation
        /// </summary>
        public int ClosedBracketCount { get; set; }

        /// <summary>
        /// Set the precedence of open bracket, for this operator, precedence is dynamically changed
        /// </summary>
        public int ClosedBracketPrecedence { get; set; }

        /// <summary>
        /// Contains numbers that read from equation before reading operator type
        /// </summary>
        public string GroupedNumbers { get; set; }

        /// <summary>
        /// contains temporary result
        /// </summary>
        public string TemporaryResult { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Define operator precedence
        /// </summary>
        /// <param name="enum_Operator"></param>
        /// <returns></returns>
        public int PrecedenceOperator(OperatorType enum_Operator)
        {
            Calculator cal = new Calculator();
            switch (enum_Operator)
            {
                case OperatorType.Add:
                    return 1;
                case OperatorType.Minus:
                    return 2;
                case OperatorType.Multiply:
                    return 3;
                case OperatorType.Divide:
                    return 3;
                case OperatorType.OpenBracket:
                    return 0;
                case OperatorType.CloseBracket:
                    return 4;
                default:
                    return -1;
            }
        }

        #endregion
    }
}
