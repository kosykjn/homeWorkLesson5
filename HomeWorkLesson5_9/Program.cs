using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");

            int inputNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            int result = GetSum(inputNumber);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int GetSum(int n)
        {
            if (n < 10)
            {
                return n;
            }

            return n % 10 + GetSum(n / 10);
        }
    }
}
