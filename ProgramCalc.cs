using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение: число оператор число (например: 5 + 3)");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            double num1 = Convert.ToDouble(parts[0]);
            double num2 = Convert.ToDouble(parts[2]);
            string operation = parts[1];
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                    }
                    result = num1 / num2;
                    break;
            }
            Console.WriteLine($"Результат: {result}");
        }
    }
}
