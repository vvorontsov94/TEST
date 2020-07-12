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

                if (operation == "+")
                {
                    Console.WriteLine("Результат:");
                    Console.WriteLine(a + b);
                }
                else
                {
                    if (operation == "-")
                    {
                        Console.WriteLine("Результат:");
                        Console.WriteLine(a - b);
                    }
                    else
                    {
                        if (operation == "*")
                        {
                            Console.WriteLine("Результат:");
                            Console.WriteLine(a * b);
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
                                    Console.WriteLine("Результат:");
                                    Console.WriteLine(a / b);
                                }
                            }
                            else
                                Console.WriteLine("Ошибка при вводе знака");
                        }
                    }
                }
                Console.ReadLine();
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
                        {
                            Console.WriteLine("Результат:");
                            Console.WriteLine(a / b);
                        }
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
