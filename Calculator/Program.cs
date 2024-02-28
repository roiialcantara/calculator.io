using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne;
            int numTwo;
            int result = 0;
            string operation;

            Console.WriteLine("Enter first number");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Enter second number");
            numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("A for Add, S for Subtract, M for Multiply, D for Divide");
            operation = Console.ReadLine();

            if (operation == "a" ||  operation == "A") {
                result = numOne + numTwo;
            }
            else if(operation == "s" || operation == "S"){ 
                result = numOne - numTwo; 
            }
            else if (operation == "m" || operation == "M")
            {
                result = numOne * numTwo;
            }
            else if (operation == "d" || operation == "D")
            {
                result = numOne / numTwo;
            }
            else
            {
                Console.WriteLine("Incorrect Operation");
            }
            Console.WriteLine("");
            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
        }
    }
}
