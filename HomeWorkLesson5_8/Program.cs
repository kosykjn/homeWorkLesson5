using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson5_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число:");

            int endNumber = Convert.ToInt32(Console.ReadLine());
            int startNumber = 0;

            Console.WriteLine(new string('*', 10));

            Recursion(startNumber, endNumber);

            Console.ReadKey();
        }

        static void Recursion(int start, int end)
        {
            start++;

            Console.WriteLine(start);

            if (start != end)
            {
                Recursion(start, end);
            }
        }
    }
}
