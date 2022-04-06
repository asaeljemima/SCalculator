using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            ConsoleKeyInfo status;
            float answer;

            while (true)
            {
                Console.Write("veuillez entrer le premier nombre: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("veuillez entre le deuxieme nombre: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("veuillez choisir un operant parmi les suivants (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
                Console.WriteLine("\n\n voullez vous arreter? (Y/y)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
