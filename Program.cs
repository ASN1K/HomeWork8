using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Creditdep(int creditDeposit, int creditValue)
        {
            creditValue += creditDeposit;
            if (creditValue < 0)
            {
                Console.WriteLine($"Ваш текуший кредит: {creditValue}");
                Console.WriteLine("Введите сумму погашения кредита");
                creditDeposit = int.Parse(Console.ReadLine());
                Creditdep(creditDeposit, creditValue);
            }
            else
            {
                Console.WriteLine($"Вы успешно погасили кредит с переплатой {creditValue}");
            }

        }
        static void Main(string[] args)
        {
            Retry:
            Console.WriteLine("Введите сумму кредита");
            int creditValue = int.Parse(Console.ReadLine());
            creditValue = -creditValue;
            Console.WriteLine($"Ваш текуший кредит: {creditValue}");
            Console.WriteLine("Введите сумму погашения кредита");
            int creditDeposit = int.Parse(Console.ReadLine());
            Creditdep(creditDeposit, creditValue);
            Console.WriteLine("Спасибо что воспользовались моей програмой \n Попробовать снва? y/n");
            string res = Console.ReadLine();
            if (res.ToLower() == "y")
            {
                goto Retry;
            }
        }
    }
}
