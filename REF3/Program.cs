using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REF3
{
    class Program
    {
        static void deleteElement<T>(ref T[] arr, uint n)
        {
            T[] bufer = new T[arr.Length - 1];
            for (uint i = 0; i < n; i++)
            {
                bufer[i] = arr[i];
            }
            for (uint i = n + 1; i < arr.Length; i++)
            {
                bufer[i - 1] = arr[i];
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

            Console.WriteLine("Вывод массива размерностью " + array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Под каким индексом удалить элемент?");
            uint ind = uint.Parse(Console.ReadLine());

            Program.deleteElement(ref array, ind);

            Console.WriteLine("Вывод нового массива размерностью " + array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
