using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-ю сторону прямоугольника:");
            int firstSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2-ю сторону прямоугольника:");
            int secondSide = Convert.ToInt32(Console.ReadLine());

            CalcRectangleValues(firstSide, secondSide, out int S, out int P);

            Console.WriteLine(@"Площадь прямоугольника {0} и периметр прямоугольника {1}", S, P);

            Console.ReadKey();
        }

        static void CalcRectangleValues(int a, int b, out int s, out int p)
        {
            s = a * b;
            p = 2 * (a + b);
        }
    }
}
