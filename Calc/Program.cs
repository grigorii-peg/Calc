using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            Console.WriteLine("Калькулятор");
            Console.Write("Введите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Выберите арифметическое действие: 

- Умножение (введите 1)
- Деление (введите 2)
- Сложение (введите 3)
- Вычитание (введите 4)
- Возведение числа в степень (введите 5)");
            string c = Console.ReadLine();
            Console.WriteLine();
            if (c == "1")
            {
                Console.WriteLine("Результат умножения = {0}", a * b);
            }
            if (c == "2")
            {
                Console.WriteLine("Результат деления = {0}", a / b);
            }
            if (c == "3")
            {
                Console.WriteLine("Результат сложения = {0}", a + b);
            }
            if (c == "4")
            {
                Console.WriteLine("Результат вычитания = {0}", a - b);
            }
            if (c == "5")
            {
                Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(a, b));
            }
            Console.ReadKey();
        }
    }
}
  