using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак арифметической операции:");
            string operation = Console.ReadLine();

            if (Calculate(number1, number2, operation, out int result))
            {
                Console.WriteLine($"Результат: {result}");
            }

            Console.ReadKey();
        }

        static bool Calculate(int number1, int number2, string operation, out int result)
        {
            result = 0;

            switch (operation)
            {
                case "+":
                    {
                        result = Add(number1, number2);
                        return true;
                    }
                case "-":
                    {
                        result = Subtraction(number1, number2);
                        return true;
                    }
                case "*":
                    {
                        result = Multiplication(number1, number2);
                        return true;
                    }
                case "/":
                    {
                        if (number2 == 0)
                        {
                            Console.WriteLine("Делить на 0 невозможно!");
                            return false;
                        }
                        result = Division(number1, number2);
                        return true;
                    }
                default:
                    {
                        Console.WriteLine("Нет такого арифметического знака!");
                        return false;
                    }
            }
        }

        #region Operations

        static int Add(int number1, int number2)
        { 
            return number1 + number2;
        }
        static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
        static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Division(int number1, int number2)
        {
            return number1 / number2;  
        }

        #endregion
    }
}
