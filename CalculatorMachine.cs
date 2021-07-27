using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class CalculatorMachine
    {
        private double firstNumber;
        private double secondNumber;
        private double result;
        private char operation;

        public CalculatorMachine(double first, double second, char opp)
        {
            firstNumber = first;
            secondNumber = second;
            operation = opp;
            Switching();
        }
        private void Switching()
        {
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    Console.WriteLine("The sum of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startover();
                    break;

                case '-':
                    result = firstNumber - secondNumber;
                    Console.WriteLine("The sub of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startover();
                    break;

                case '*':
                    result = firstNumber * secondNumber;
                    Console.WriteLine("The multiply of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startover();
                    break;

                case '/':
                    result = firstNumber / secondNumber;
                    Console.WriteLine("The div of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startover();
                    break;


                default:
                    Console.WriteLine("Invalid operation.Please enter valid operation ");
                    End();
                    break;
            }
        }


        private void startover()
        {
            Console.WriteLine("You want to do more? if \'yes\' then press and enter (Y). " +
       "Else enter any key");
            string YesorNo = Console.ReadLine();
            bool mybool = (YesorNo == "y") || YesorNo == "Y";
            if (mybool == true)
            {
                repeat();
            }
            else
            {
                End();
            }
        }
        private void repeat ()
        {
            firstNumber = result;
            Console.WriteLine("Input second Number:");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation : (+ , - , * , /)");
            operation = char.Parse(Console.ReadLine());
            Switching();
        }
        private void End ()
        {
            Console.WriteLine("Final Result is {0}", result);
            Console.WriteLine("Press any key to Exit the Calculator");
            Console.ReadKey();
        }
    }
}
            


