using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_9
{
    public class Calculator
    {

        public double FirstOperand { get; set; }
        public double SecondOperand { get; set; }
        private string _operator;
        private double _result;
        public string Operator
        {
            set
            {
                if (value == "+" ||
                    value == "-" ||
                    value == "*" ||
                    value == "/")
                {
                    _operator = value;
                }
            }
        }

        public void PrintOptions()
        {
            Console.WriteLine("Options : ");
            Console.WriteLine("\t + : Add ");
            Console.WriteLine("\t - : Substract ");
            Console.WriteLine("\t * : Multiply ");
            Console.WriteLine("\t / : Divide ");
            Console.Write("Enter an option :");
        }

        public void Process()
        {
            switch (_operator)
            {
                case "+":
                    _result = FirstOperand + SecondOperand;
                    break;
                case "-":
                    _result = FirstOperand - SecondOperand;
                    break;
                case "*":
                    _result = FirstOperand * SecondOperand;
                    break;
                case "/":
                    _result = FirstOperand / SecondOperand;
                    break;
                default:
                    throw new Exception("That was not a valid option !!!");
            }

        }

        public override string ToString()
        {
            return $"Result -> {FirstOperand} {_operator} {SecondOperand} = {_result}";
        }



    }
}