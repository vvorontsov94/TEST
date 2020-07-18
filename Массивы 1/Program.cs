using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int n, sum, min;
                sum = 0;
                int[] MYarray;

                Console.Clear();
                Console.WriteLine("Введи размер массива");
                
                try
                {
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    MYarray = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Введи элемент " + i + " массива");
                        MYarray[i] = int.Parse(Console.ReadLine());
                    }
                }

                catch(Exception)
                {
                    Console.WriteLine("Вводи числа правильно");
                    Console.ReadLine();
                    continue;
                }


                Console.WriteLine();
                Console.WriteLine("Вывод массива");
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine("Элемент " + i + ": " + MYarray[i]);
                }


                Console.WriteLine();
                Console.WriteLine("Вывод массива в обратном порядке");
                for (int i = MYarray.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine("Элемент " + i + ": " + MYarray[i]);
                }

                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    if (MYarray[i] % 2 == 0)
                    {
                        sum += MYarray[i];
                    }
                }
                Console.WriteLine("Сумма четных чисел в массиве: " + sum);

                Console.WriteLine();
                min = MYarray[0];
                for (int i = 0; i < n; i++)
                {
                    if (MYarray[i] < min)
                    {
                        min = MYarray[i];
                    }
                }
                Console.WriteLine("Минимальный элемент массива: " + min);

                Console.ReadLine();



            }
        }
    }
}
