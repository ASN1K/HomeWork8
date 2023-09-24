using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Calculate(ref int number1, ref int number2, ref int number3)
        {
            number1 = number1 / 5;
            number2 = number2 / 5;
            number3 = number3 / 5;
        }
        static void Main(string[] args)
        {
            Retry:
            Console.WriteLine("Введите 1 число");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 число");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Числа до модификации{number1},{number2},{number3}");
            Calculate(ref number1, ref number2, ref number3);
            Console.WriteLine($"Числа после модификации{number1},{number2},{number3}");
            Console.WriteLine("Попробовать снова \n y/n");
            string res = Console.ReadLine();
            if (res == "y")
            {
                goto Retry;
            }
        }
    }
}
