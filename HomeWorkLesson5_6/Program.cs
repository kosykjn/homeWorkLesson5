using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOut(out int xOut, out int yOut, out int zOut);
            Console.WriteLine(@"{0} {1} {2}", xOut, yOut, zOut);

            int xRef = 0;
            int yRef = 0;
            int zRef = 0;

            MethodRef(ref xRef, ref yRef, ref zRef);

            Console.WriteLine(@"{0} {1} {2}", xRef, yRef, zRef);

            Console.ReadKey();
        }

        static void MethodOut(out int arg1, out int arg2, out int arg3)
        {
            arg1 = 3 * 10;
            arg2 = 2 * 10;
            arg3 = 4 * 10;
        }

        static void MethodRef(ref int arg1, ref int arg2, ref int arg3)
        {
            arg1 = 3 * 10;
            arg2 = 2 * 10;
            arg3 = 4 * 10;
        }
    }
}
