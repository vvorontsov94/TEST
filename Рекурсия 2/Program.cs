using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия_2
{
    class Program
    {

        /*
        static void output(int[] arr, int i)
        {
            if (i >= arr.Length)
                return;

            Console.Write(arr[i] + " ");
            i++;

            output(arr, i);
        }
        */

        static void output(int[] arr, int i = 0)
        {
            if (i < arr.Length)
            {
                Console.Write(arr[i] + " ");
                output(arr, i + 1);
            }
        }


        static int sum(int[] arr, int i = 0, int result = 0)
        {
            if (i < arr.Length)
            {
                result += arr[i];
                result = sum(arr, i + 1, result);
            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введи размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(20);
            }

            Console.WriteLine("Вывод массива");
            output(array);
            Console.WriteLine();
            Console.WriteLine("Сумма элементов массива: " + sum(array));

        }
    }
}
