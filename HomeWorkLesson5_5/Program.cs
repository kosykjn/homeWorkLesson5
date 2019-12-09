using System;

namespace HomeWorkLesson5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("На какую валюту вы хотите поменять: Евро, Доллар, Рубль ?");
            string currency = Console.ReadLine();

            Console.WriteLine("Какую сумму вы желаете поменять?");
            double money = Convert.ToDouble(Console.ReadLine());

            switch(currency)
            {
                case "Евро":
                {
                    Console.WriteLine($"Сумма в итоге {CurrencyEuro(money)} евро");
                    break;
                }
                case "Доллар":
                {
                    Console.WriteLine($"Сумма в итоге {CurrencyDollar(money)} доларов");;
                    break;
                }
                case "Рубль":
                {
                    Console.WriteLine($"Сумма в итоге {CurrencyRub(money)} рублей");
                    break;
                }
                default:
                {
                    Console.WriteLine("Нет такой валюты! ");
                    break;
                }
            }

            Console.ReadKey();
        }

        static double CurrencyDollar (double money)
        {
            return money / 23.6;
        }
        static double CurrencyEuro(double money)
        {
            return money / 26.2;
        }
        static double CurrencyRub(double money)
        {
            return money * 2.6;
        }
    }
}
