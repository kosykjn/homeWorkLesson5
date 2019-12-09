using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Method(5,2,8));

            Console.ReadKey();
        }

        static double Method(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
    }
}
