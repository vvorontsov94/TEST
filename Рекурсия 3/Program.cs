using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия_3
{
    class Program
    {
        static int sum(int n)
        {
            if (n == 0)
                return 0;
                        
            int bufer = n % 10;
            n /= 10;
            return bufer + sum(n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введи число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(sum(n));
        }
    }
}
