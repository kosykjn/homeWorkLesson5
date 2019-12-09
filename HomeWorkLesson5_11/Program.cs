using System;

namespace HomeWorkLesson5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double credit = 0;
            double minPay = 100;

            while(true)
            {
                Console.WriteLine("Введите желаемый кредит:");
                credit = Convert.ToDouble(Console.ReadLine());

                if (credit >= minPay)
                {
                    Console.WriteLine($"Поздравляем! Вы получили кредит в размере {credit}");
                    break;
                }
                else
                {
                    Console.WriteLine("Пфф... мы тебе что MoneyVeo, таких копеек взаймы не даем!");
                }
            }

            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Пора начинать отдавать долг, ДОЛЖНИК!!!");
            Console.WriteLine(new string('*', 50));

            while (true)
            {
                Console.WriteLine("Введите сумму на которую хотите погасить вашу задолженость:");
                double value = Convert.ToDouble(Console.ReadLine());

                if (Pay(ref credit, value, minPay))
                {
                    break;
                }
            }

            Console.ReadKey();
        }

        static bool Pay(ref double credit, double putValue, double minPay)
        {
            if (putValue < 0)
            {
                Console.WriteLine("Куда тебе еще денег, ты и так наш ДОЛЖНИК!!! Пшел отсюдова!");
                return false;
            }

            if (putValue < minPay)
            {
                Console.WriteLine("Дружище, разве это деньги. Шел бы ты, да поднакопил бы малость деньжат!");
                return false;
            }

            credit -= putValue;

            if (credit < 0)
            {
                Console.WriteLine($"Банк признателен за вашу щедрость в размере {Math.Abs(credit)}! Да хранит Вас Бог! Вы свободны!");
                return true;
            }
            else if (credit == 0)
            {
                Console.WriteLine("Долг выплачен! Вы свободны:)");
                return true;
            }
            else
            {
                Console.WriteLine($"Вы внесли сумму в размере: {putValue}! Текущая задолженость: {credit}");
                return false;
            }
        }
    }
}
