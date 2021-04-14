using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Shunting_Yard_Ver_1
{   
        class Calculator
        {

            #region Stacks
            //Stack to store numbers
            private Stack<double> numbers_stack = new Stack<double>();

            //stack to store operators
            private Stack<OperatorType> operator_stack = new Stack<OperatorType>();
            #endregion


            #region Parsing equation
            /// <summary>
            /// Parse equation from string to numbers and operators
            /// </summary>
            public string ParseEquation(string input_equation)
            {
                //Create an operation object 
                Operation Operation = new Operation();
                try
                {   
                    // set the flag for operator permission
                    //bool operator_permit = true;

                    //loop throughout equation string
                    for (var i = 0; i < input_equation.Length; i++)
                    {
                        //checks if numbers 
                        if ("01234567890.".Any(ch => input_equation[i] == ch))
                        {
                            //input_equation character is number
                            //assign to grouped numbers
                            Operation.GroupedNumbers += input_equation[i];

                            //if the number is the last element in string
                            //push numbers
                            if (i == input_equation.Length - 1)
                                PushNumber(Operation);
                        }

                        //Checks if operator 
                        else if ("+-*/()".Any(ch => input_equation[i] == ch))
                        {
                            //input_equation character is operator
                            //get operator
                            var input_operator_type = GetOperator(input_equation[i]);

                            //counts for open bracket or closed bracket
                            BracketCount(Operation, input_operator_type);

                            //counts for other operator other than brackets
                            NoBracketCount(Operation, input_operator_type);

                            //checks if groupednumbers is empty 
                            if (Operation.GroupedNumbers == string.Empty)
                            {
                                //checks if the operator is minus
                                if (input_operator_type == OperatorType.Minus)
                                    //assign character '-' to grouped numbers
                                    Operation.GroupedNumbers += input_equation[i];

                                //checks if the operator is open brackets
                                else if (input_operator_type == OperatorType.OpenBracket)
                                    // push character to operator_stack
                                    operator_stack.Push(input_operator_type);

                                //if total number of operator is less than total number in numbers_stack right now
                                else if (Operation.NoBracketCount <= numbers_stack.Count)
                                    //push character to operator stack
                                    operator_stack.Push(input_operator_type);

                                //if first character is not valid
                                else
                                    throw new InvalidOperationException("");
                            }

                            // grouped numbers is not empty, assign operator to stack
                            else
                            {

                                //Checks if current operation is valid
                                if (!CheckOperationRule(Operation, input_operator_type))
                                {
                                    throw new InvalidOperationException("");
                                }

                                //// push grouped numbers to numbers_stack
                                PushNumber(Operation);

                                // empty grouped numbers 
                                Operation.GroupedNumbers = string.Empty;

                                //checks precedence operator
                                //if current operator type precedence higher than last member from the stack, push to stack.
                                if (CheckPrecedence(Operation, input_operator_type))
                                {
                                    if (input_operator_type == OperatorType.CloseBracket && Operation.OpenBracketCount != 0)
                                    {

                                        //push operator to stack
                                        operator_stack.Push(input_operator_type);

                                        //call PopStack function to perform calculation
                                        PopStack(Operation, input_operator_type);
                                    }
                                    else
                                        //push operator to stack and not closed bracket
                                        operator_stack.Push(input_operator_type);
                                }

                                //otherwise calculate
                                else
                                {
                                    //call PopStack function to perform calculation
                                    PopStack(Operation, input_operator_type);

                                    //push operator to stack
                                    operator_stack.Push(input_operator_type);
                                }
                            }
                        }
                        //Checks if other than numbers or valid equation
                        else
                        {
                            throw new InvalidOperationException("Invalid operator");
                        }
                    }

                }
                catch (Exception ex)
                {
                    return ($"Error Invalid Equation {ex.Message}");
                }

                //Last check for brackets
                try
                {
                    //calculate the remaining operand in stack no more bracket
                    PopStack(Operation);

                    //checks for operation rule again, make sure no operator in operator_stack
                    if (operator_stack.Count != 0)
                    {
                        throw new InvalidOperationException("There's bracket left");
                    }

                    //this is the last result
                    var temporaryresult = numbers_stack.Pop();

                    //clears numbers stack and operator stack
                    operator_stack.Clear();
                    numbers_stack.Clear();


                    //send to main program
                    return temporaryresult.ToString();


                }
                catch (Exception ex)
                {
                    return ($"Error Invalid brackets {ex.Message}");
                }
            }
            #endregion



            #region calculate

            /// <summary>
            /// pops operator_stack and numbers_stack because operator that about to come holds lower precedence than
            /// stack and stack currently holds.
            /// </summary>
            /// <param name="operation"></param>
            /// <returns></returns>
            private void PopStack(Operation operation, OperatorType current_operator)
            {
                //variable for peeking operator type in operator_stack
                var peek_operator_type_in_stack = operator_stack.Peek();

                //variable for getting operator type in operator_stack
                OperatorType operator_type_in_stack;

                //while last element in stack is closedbracket
                while (peek_operator_type_in_stack == OperatorType.CloseBracket)
                {
                    //keep popping stack if the current element is close bracket
                    operator_type_in_stack = operator_stack.Pop();

                    //decrement closedbracket count
                    operation.ClosedBracketCount = operation.ClosedBracketCount - 1;

                    //peek last element from operator stack
                    peek_operator_type_in_stack = operator_stack.Peek();
                }


                //loops for continously pops operator_stack
                while (operator_stack.Count != 0)
                {
                    //pops operator in stack
                    operator_type_in_stack = operator_stack.Pop();

                    //checks if operator in stack is open bracket
                    if (operator_type_in_stack == OperatorType.OpenBracket)
                    {
                        //decrement total openbracket count
                        operation.OpenBracketCount -= 1;

                        return;
                    }
                    //checks if number_stack only has one member
                    else if (numbers_stack.Count < 2)
                        //return if number_stack only has one member
                        //the only one element is temporary result 
                        return;
                    else
                    {
                        //pops two last elements from numbers_stack
                        var operand1 = numbers_stack.Pop();
                        var operand2 = numbers_stack.Pop();

                        //calculate and update stack and stack
                        Calculate(operation, operator_type_in_stack, operand1, operand2);
                    }

                }
                return;

            }
            /// <summary>
            /// overload version Popstack
            /// </summary>
            /// <param name="operation"></param>
            private void PopStack(Operation operation)
            {
                //variable for getting operator type in operator_stack
                OperatorType operator_type_in_stack;

                //checks if there's no Nobracket operator, then exits with throw
                if (operation.NoBracketCount == 0 && numbers_stack.Count !=1)
                    throw new InvalidOperationException("there's no operator to calculate");

                //loops for continously pops operator_stack
                while (operator_stack.Count != 0)
                {
                    //pops last element from operator stack that is not closedbracket
                    operator_type_in_stack = operator_stack.Pop();

                    //checks if operator in stack is open bracket
                    if (operator_type_in_stack == OperatorType.OpenBracket)
                    {
                        //decrement total openbracket count
                        operation.OpenBracketCount -= 1;

                        return;
                    }
                    //checks if number_stack only has one member
                    else if (numbers_stack.Count < 2)
                        //return if number_stack only has one member
                        //the only one element is temporary result 
                        return;
                    else
                    {
                        //pops two last elements from numbers_stack
                        var operand1 = numbers_stack.Pop();
                        var operand2 = numbers_stack.Pop();

                        //calculate and update stack and stack
                        Calculate(operation, operator_type_in_stack, operand1, operand2);
                    }
                }


            }


            /// <summary>
            /// Calculate between 2 operands
            /// </summary>
            /// <param name="Type"></param>
            /// <param name="operand1"></param>
            /// <param name="operand2"></param>
            private void Calculate(Operation operation, OperatorType Type, double operand1, double operand2)
            {
                //temporary result
                double temp_result;

                //switch case for operator type
                switch (Type)
                {
                    case OperatorType.Add:
                        temp_result = operand1 + operand2; break;
                    case OperatorType.Minus:
                        temp_result = operand2 - operand1; break;
                    case OperatorType.Multiply:
                        temp_result = operand1 * operand2; break;
                    case OperatorType.Divide:
                        temp_result = operand2 / operand1; break;
                    default: return;

                }
                //No bracket operator minus one
                operation.NoBracketCount = operation.NoBracketCount - 1;

                //push numbers
                numbers_stack.Push(temp_result);
            }


            #endregion



            #region operator


            /// <summary>
            /// Checks the precedence operator
            /// </summary>
            /// <param name="current_operator_type"></param>
            /// <returns></returns>
            private bool CheckPrecedence(Operation Operation, OperatorType current_operator_type)
            {
                OperatorType last_operator_in_stack;
                int last_member_stack_precedence;
                int current_operator_precendence;

                //if operator stack contains no member, then return true
                if (operator_stack.Count == 0)
                {
                    return true;
                }
                //there's member (s) in stack operator
                else
                {
                    //Total current element at stack
                    int count_element = operator_stack.Count;

                    //get the last elemet from operator_stack
                    last_operator_in_stack = operator_stack.Peek();

                    //get precedence of last element of the stack
                    last_member_stack_precedence = Operation.PrecedenceOperator(last_operator_in_stack);

                    //get precedence of currently read operator
                    current_operator_precendence = Operation.PrecedenceOperator(current_operator_type);

                    //checks if operator in stack less than equal compared to current operator type
                    //if current operator type precedence larger than last member from the stack, returns true.
                    //otherwise returns false
                    if (last_member_stack_precedence < current_operator_precendence)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }


            /// <summary>
            /// Checks if operation rule valid as to mathematical rules
            /// Specially open brackets and closed bracket is treated differently
            /// </summary>
            /// <returns></returns>
            private bool CheckOperationRule(Operation Operation, OperatorType input_operator_type)
            {
                // grouped numbers only contains '-', cannot proceed equation or 
                if (Operation.GroupedNumbers == "-")
                    return false;
                //input_operator_type equals to open bracket and at the right operand
                else if (input_operator_type == OperatorType.OpenBracket && Operation.GroupedNumbers != string.Empty)
                    return false;
                //input_operator_type equals to closed bracket and there is no openbracket
                else if (input_operator_type == OperatorType.CloseBracket && Operation.OpenBracketCount == 0)
                    return false;
                //input_operator_type equals to closed bracket and there is no numbers before
                else if (input_operator_type == OperatorType.CloseBracket && Operation.GroupedNumbers == string.Empty)
                    return false;
                // other than the condition above, program may proceed
                else
                    return true;
            }

            /// <summary>
            /// overload function, with one argument for checkoperation
            /// </summary>
            /// <param name="Operation"></param>
            /// <returns></returns>
            private bool CheckOperationRule(Operation Operation)
            {

                if (Operation.NoBracketCount != numbers_stack.Count - 1)
                    return false;
                else
                    return true;
            }


            /// <summary>
            /// Counts the total number for brackets
            /// </summary>
            /// <param name="Operation"></param>
            /// <param name="current_operator"></param>
            private void BracketCount(Operation Operation, OperatorType current_operator)
            {
                //counts for open bracket detected
                if (current_operator == OperatorType.OpenBracket)
                    Operation.OpenBracketCount += 1;
                //counts for closed bracket detected
                else if (current_operator == OperatorType.CloseBracket)
                    Operation.ClosedBracketCount += 1;
                else
                    return;
            }

            /// <summary>
            /// counts the total number for operator other than brackets
            /// </summary>
            /// <param name="Operation"></param>
            /// <param name="current_operator"></param>
            private void NoBracketCount(Operation Operation, OperatorType current_operator)
            {
                if (current_operator == OperatorType.Add)
                    Operation.NoBracketCount += 1;
                else if (current_operator == OperatorType.Minus)
                    Operation.NoBracketCount += 1;
                else if (current_operator == OperatorType.Multiply)
                    Operation.NoBracketCount += 1;
                else if (current_operator == OperatorType.Divide)
                    Operation.NoBracketCount += 1;
                else
                    return;
            }

            /// <summary>
            /// Get operator
            /// </summary>
            /// <param name="input_char"></param>
            /// <returns></returns>
            private OperatorType GetOperator(char input_char)
            {
                switch (input_char)
                {
                    case '+':
                        return OperatorType.Add;
                    case '-':
                        return OperatorType.Minus;
                    case '*':
                        return OperatorType.Multiply;
                    case '/':
                        return OperatorType.Divide;
                    case '(':
                        return OperatorType.OpenBracket;
                    case ')':
                        return OperatorType.CloseBracket;
                    default:
                        throw new InvalidOperationException($"Unidentified Operator {input_char}");
                }
            }

            #endregion

            #region Push Numbers

            /// <summary>
            /// push number to stack
            /// </summary>
            /// <param name="Operation"></param>
            private void PushNumber(Operation Operation)
            {
                //variable for parsing numbers to double
                double num;

                //try parse
                if (!double.TryParse(Operation.GroupedNumbers, out num))
                {
                    throw new InvalidOperationException("Numbers cannot be parsed");
                }

                //push number
                numbers_stack.Push(num);

            }
            #endregion
        }
}
