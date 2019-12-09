using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш год рождения:");

            int birthYear = Convert.ToInt32(Console.ReadLine());

            int userAge = GetAge(birthYear);

            Console.WriteLine(string.Format(@"Вам {0} лет", userAge));

            Console.ReadKey();
        }

        static int GetAge(int year)
        {
            return DateTime.Now.Year - year;
        }
    }
}
