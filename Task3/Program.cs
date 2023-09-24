using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static int Factoriial(int cust)
        {
            if (cust <= 0)
            {
                return 0;
            }
            if (cust == 1) 
            {
                return  1;
            }
            return cust * Factoriial(cust - 1);
        }

        static void Main(string[] args)
        {
            Retry:
            Console.WriteLine("Введите количество киентов");
            int customers = int.Parse(Console.ReadLine());
            int routs = Factoriial(customers);
            Console.WriteLine($"Количесво возможных маршрутов:{routs}");
            Console.WriteLine("Спасибо что воспользовались моей програмой \n Попробовать снва? y/n");
            string res = Console.ReadLine();
            if (res.ToLower() == "y")
            {
                goto Retry;
            }
        }
    }
}
