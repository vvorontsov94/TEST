using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApp1
{
    class Test
    {
        static void Main()
        {
            // Калькулятор на ифах 
            /*
            double a, b, result;
            string operation;
            Console.WriteLine("Это калькулятор, пидор");
            Console.WriteLine("Введи первое число");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи + - * /");
            operation = Console.ReadLine();
            Console.WriteLine("Введи второе число");
            b = double.Parse(Console.ReadLine());

            result = 0;                                                   // ИНИЦИАЛИЗАЦИЯ - нельзя оставлять переменные неприсвоенными, если что-то с ними делать собираешься (также можно поставить в дефолт)

            if (operation == "+")
            {
            result = a + b;                                               // Можно прописать действие в writeline, тогда не нужна переменная result !!!
            }
            else
            {
                if (operation == "-")
                {
                    result = a - b;
                }
                else
                {
                    if (operation == "*")
                    {
                        result = a * b;
                    }
                    else
                    {
                        if (operation == "/")
                        {
                            if (b == 0)
                            {
                                Console.WriteLine("Делить на 0 нельзя");
                            }
                            else
                            {
                                result = a / b;
                            }
                        }
                        else
                            Console.WriteLine("Ошибка");
                    }
                }
                                                          
            }


            if (result != 0)
            {
                Console.WriteLine("Результат:");
                Console.WriteLine(result);
            }
            */







            // Калькулятор на свитче

            while (true)
            {
                Console.Clear();
                double a, b;
                string operation;

                try
                {
                    Console.WriteLine("Это калькулятор, пидор");
                    Console.WriteLine("Введи первое число");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введи + - * /");
                    operation = Console.ReadLine();
                    Console.WriteLine("Введи второе число");
                    b = double.Parse(Console.ReadLine());
                }
                
                catch(Exception)

                {
                    Console.WriteLine("Долбоёб, вводи числа правильно");
                    Console.ReadLine();
                    continue;
                }


                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Результат:");
                        Console.WriteLine(a + b);
                        break;

                    case "-":
                        Console.WriteLine("Результат:");
                        Console.WriteLine(a - b);
                        break;

                    case "*":
                        Console.WriteLine("Результат:");
                        Console.WriteLine(a * b);
                        break;

                    case "/":
                        if (b == 0)                                            //  Если под if или else одна строка, можно не ставить фигурные скобки
                            Console.WriteLine("Делить на 0 нельзя");
                        else
                            Console.WriteLine("Результат:");
                            Console.WriteLine(a / b);
                        break;

                    default:
                        Console.WriteLine("Ошибка при вводе операции");
                        break;
                }

               Console.ReadLine();
            }

        }
                    
    }
}
