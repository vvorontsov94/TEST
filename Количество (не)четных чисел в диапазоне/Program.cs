using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Количество__не_четных_чисел_в_диапазоне
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int nachalo, konec, countCHET, countNECHET;
                Console.Clear();

                try
                {

                    Console.WriteLine("Определение количества четных и нечетных чисел в введенном диапазоне");
                    Console.WriteLine("Введи начало диапазона целых чисел");
                    nachalo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введи конец диапазона целых чисел");
                    konec = int.Parse(Console.ReadLine());
                }

                catch(Exception)
                {
                    Console.WriteLine("Вводи числа правильно");
                    Console.ReadLine();
                    continue;
                }


                countCHET = 0;
                countNECHET = 0;


                while (nachalo <= konec)
                {
                    if (nachalo % 2 == 0)
                        countCHET++;
                    else
                    {
                        countNECHET++;
                    }
                    nachalo++;
                }

                Console.WriteLine("Количество четных чисел в диапазоне");
                Console.WriteLine(countCHET);
                Console.WriteLine("Количество нечетных чисел в диапазоне");
                Console.WriteLine(countNECHET);
                Console.ReadLine();
            }
        }
    }
}
