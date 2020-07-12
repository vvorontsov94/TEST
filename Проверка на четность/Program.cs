using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Проверка_на_четность
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int chislo;
                Console.WriteLine("Проверка числа на четность");
                Console.WriteLine("Введите число");

                try
                {
                    chislo = int.Parse(Console.ReadLine());
                }

                catch(Exception)
                {
                    Console.WriteLine("Вводи число правильно");
                    Console.ReadLine();
                    continue;
                }


                if (chislo % 2 == 0)
                {
                    Console.WriteLine("Введенное число " + chislo + " является четным");
                }
                else
                {
                    Console.WriteLine("Введенное число " + chislo + " является нечетным");
                }
                Console.ReadLine();
            }
        }
    }
}
