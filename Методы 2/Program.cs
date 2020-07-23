using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы_2
{
    class Program
    {

        static int search(int[] array0, int number)
        {
            for (int i = 0; i < array0.Length; i++)
            {
                if (array0[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введи кол-во элементов");
            n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            Console.WriteLine("Введи массив");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Введи элемент, индекс которого хочешь найти");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Индекс искомого элемента: " + search(array1, element));




        }
    }
}
