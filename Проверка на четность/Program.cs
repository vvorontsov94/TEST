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
            Console.WriteLine("Проверка числа на четность");
            Console.WriteLine("Введите число");
            int chislo = int.Parse(Console.ReadLine());
            if (chislo % 2 == 0)
                {
                Console.WriteLine("Введенное число " + chislo + " является четным");
            }
            else
            {
                Console.WriteLine("Введенное число " + chislo + " является нечетным");
            }
        }
    }
}
