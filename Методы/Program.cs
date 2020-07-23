using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы
{
    class Program
    {
        static void output(string str, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(str + " ");
            }

        }

        static void Main(string[] args)
        {
            while(true)
            {
                string str;
                uint n;
                Console.Clear();
                try
                {
                    Console.WriteLine("Введи символы");
                    str = Console.ReadLine();
                    Console.WriteLine("Введи количество повторений");
                    n = uint.Parse(Console.ReadLine());
                }

                catch(Exception)
                {
                    Console.WriteLine("Вводи правильно");
                    Console.ReadLine();
                    continue;
                }
                
                Program.output(str, n);
                Console.ReadLine();

            }
           
        }
    }
}
