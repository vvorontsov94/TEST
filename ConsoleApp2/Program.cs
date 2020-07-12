using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Среднее арифметическое двух чисел");
            Console.WriteLine("Введите первое число");
            string a = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            /* string b = Console.ReadLine(); */
            double b2 = double.Parse(Console.ReadLine());
            double c = Convert.ToDouble(a);
           /* double d = Convert.ToDouble(b); */
            double result = (c + b2) / 2;
            Console.WriteLine(result);

        }
    }
}
