using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Треугольники__вложенные_циклы_
{
    class Program
    {
        static void Main(string[] args)
        {

            int size;
            string symbol;

            while (true)
            {
                
                Console.Clear();

                Console.WriteLine("Треугольники");
                                
                try
                {
                    Console.WriteLine("Введи размер");
                    size = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введи символ");
                    symbol = Console.ReadLine();
                }

                catch(Exception)
                {
                    Console.WriteLine("Вводи размер правильно");
                    Console.ReadLine();
                    continue;
                }

                Console.Clear();


                for (int i = 1; i <= size; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                for (int i = 1; i <= size; i++)
                {
                    for (int j = 1; j <= size + 1 - i; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                                             
                Console.WriteLine();

                for (int i = 1; i <= size; i++)
                {
                    for (int k = 1; k <= size - i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                for (int i = 1; i <= size; i++)
                {
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= size + 1 - i; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();

            }

        }
    }
}
