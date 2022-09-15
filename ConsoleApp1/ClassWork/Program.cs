using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ClassWork
{
    class ClWork
    {
        static void Main(string[] args)
        {
            //1 ZADACA
            Console.WriteLine("1 ZADACA. Введение имени пользователя на консоль");
            Console.Write("Введите своё имя) ");
            string name = Console.ReadLine();
            Console.WriteLine($"САЛАМ АЛЕЙКУМ, {name}" + "\n");

            // 2 ZADACA
            Console.WriteLine("2 ZADACA. Деление первого числа на авторое");
            Console.Write("Введите первое число ");
            double num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число ");
            double num2 = int.Parse(Console.ReadLine());
            if (num2 != 0)
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}" + "\n");
            else
                Console.WriteLine("NA ZERO DELIT NELIZYA" + "\n");


            // 3 ZADACA 
            Console.WriteLine("3 ZADACA. Изучаем алфавит");
            Console.Write("Введите символ ");
            string stroka = Console.ReadLine();
            char bukva = stroka[stroka.Length - 1];
            int ascii = (int)bukva;
            char answer = (char)(ascii + 1);
            Console.WriteLine(answer + "\n");

            // 4 zadaca
            Console.WriteLine("4 ZADACA. Вычесление корней квадратного уравнения");

            Console.Write("Введите коэфицент a ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите коэфицент b ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите коэфицент c ");
            double c = double.Parse(Console.ReadLine());

            KvUrav(a, b, c);
            /*for(; ; )
            {
                Console.Write("1000-7? ");
                //Console.ReadLIne();
            }*/



            static void KvUrav(double a, double b, double c)
            {
                /* a,b и c это коэфиценты квадратного уравнения. 
                 * Метод считает корни и печатает их, если дискриминант неотрицательный. 
                 * Если дискриминант отрицательный, то будет исключение.
                 * Если а == 0, то метод посчитает корни как в линейном уравнение.   */
                double des = (b * b) - 4 * a * c;
                if (a != 0)
                {
                    if (des > 0)
                    {
                        Console.WriteLine($"x1 = {(-b + Math.Sqrt(des)) / 2 * a}");
                        Console.WriteLine($"x2 = {(-b - Math.Sqrt(des)) / 2 * a}");
                    }
                    else if (des == 0)
                    {
                        Console.WriteLine($"x = {-b / 2}");
                    }
                    else
                    {
                        Console.WriteLine("Дискриминант отрицательный.");
                        Console.WriteLine("Комплексные корни не умею считать :(");
                        Console.WriteLine("Сам Прогай Такое((");
                    }
                }
                else
                    Console.WriteLine($"x = {-c / b}");// с кайфом;
            }
        }
    }

}