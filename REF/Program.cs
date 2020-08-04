using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REF
{
    class Program
    {
        static void Resize<T>(ref T[] arr, int n)
        {
            T[] bufer = new T[n];
            for (int i = 0; i < Math.Min(arr.Length, bufer.Length); i++)
            {
                bufer[i] = arr[i];
            }

            arr = bufer;

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

            Console.WriteLine("Вывод массива, размерностью " + array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Новый размер массива?");
            int action = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Program.Resize(ref array, action);

            Console.WriteLine("Вывод измененного массива, размерностью " + array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
