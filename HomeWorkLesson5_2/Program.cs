using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLowest(5,4));

            Console.ReadKey();
        }

        static int GetLowest(int a, int b)
        {
            return a < b ? a : b;
        }
    }
}
