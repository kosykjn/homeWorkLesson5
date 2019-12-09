using System;

namespace HomeWorkLesson5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");

            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            DigitsInNumber(inputNumber, ref counter);

            Console.WriteLine(counter);

            Console.ReadKey();
        }

        static int DigitsInNumber(int userNumber, ref int counter)
        {
            int result = userNumber / 10;

            counter++;

            if (result > 0)
            {
                DigitsInNumber(result, ref counter);
            }

            return counter;
        }
    }
}
