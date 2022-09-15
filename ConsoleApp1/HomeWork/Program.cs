using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork
{
    class Proga
    {
        static void Main(string[] args)
        {

            //Console.ResetColor();// возвращяет дефолт. значение цвета консоли.
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.White;
            //!!!!!!!!Thread.Sleep(10000);//Подождать 10 секунд
            /*zad1();
            zad2();
            zad3();
            zad4();
            zad5();
            zad6();
            zad7();
            zad8();
            zad9();
            zad10();
            zad14();
            zad15();
            zad20();*/
            static void zad1()
            {
                Console.WriteLine("1 ZADANIE. chislo E");
                Console.WriteLine(Math.Round(Math.E, 1));
                Console.WriteLine();
                Console.ReadKey();
            }
            static void zad2()
            {
                Console.WriteLine("2 ZADANIE");
                Console.WriteLine(50);
                Console.WriteLine(10);
                Console.WriteLine();
                Console.ReadKey();
            }
            static void zad3()
            { 
                Console.Write("3 ZADANIE. Введите 4 числа через пробел ");
                var numbers = (Console.ReadLine()).Split();
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine();
            }
            static void zad4()
            { 
                Console.Write("4 ZADANIE. (Добавить 10) Введите число ");
                int num4 = int.Parse(Console.ReadLine());
                Console.WriteLine(num4 + 10);
                Console.WriteLine();
            }
            static void zad5()
            { 
                Console.Write("5 ZADANIE. Введите сторону квадрата ");
                int storona_kvadrata = int.Parse(Console.ReadLine());
                Console.WriteLine($"Периметр Квадрата = {storona_kvadrata * 4}");
                Console.WriteLine();
            }
            static void zad6()
            { 
                Console.WriteLine("6 ZADANIE. Введите радиус окружности");
                double rad = double.Parse(Console.ReadLine());
                Console.WriteLine($"Длина окружности = {Math.Round(2 * Math.PI * rad, 4)}. " +
                    $"Площадь круга = {Math.Round(Math.PI * rad * rad, 4)}");
                Console.WriteLine();
            }
            static void zad7()
            {
                Console.Write("7 ZADANIE. Вычисляем cos(x). Введите x ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Cos(x));
                Console.WriteLine();
            }
            static void zad8()
            { 
                Console.Write("8 ZADANIE. Введите 3 числа через пробел: " +
                    "1 основание, 2 основание, высоту трапеции ");
                var spisok = Console.ReadLine().Split();
                double FOsnov = double.Parse(spisok[0]);
                double SOsnov = double.Parse(spisok[1]);
                double height = double.Parse(spisok[2]);
                double BStorona = Math.Sqrt(Math.Pow(Math.Abs(FOsnov - SOsnov) / 2, 2) + height * height);
                Console.WriteLine($"Периметр = {2 * BStorona + FOsnov + SOsnov}");
                Console.WriteLine();
            }
            static void zad9()
            { 
                Console.Write("9 ZADANIE." +
                    "Введите количество кг конфет, печенья, яблок по порядку.Через пробел ");
                double[] cousts = { 2, 2, 2 };// в задание сказано было, что цены даны. поэтому я сделал так))
                var xyz = Console.ReadLine().Split();// cousts это цены за кг. 1 число-
                                                     // это цена конфет,
                                                     // 1 - печенья, а 3 яблок.
                double[] doublexyz = new double[3];
                double sum = 0;
                for (int i = 0; i < xyz.Length; i++)
                {
                    doublexyz[i] = double.Parse(xyz[i]);
                    sum += doublexyz[i] * cousts[i];
                }
                Console.WriteLine($"Стоимость всей покупки = {sum} \n");
                Console.ReadKey();
            }
            static void zad10()
            { 
                Console.WriteLine("10 ZADANIE. PEACE WORK MAY");
                Console.WriteLine("МИР ТРУД МАЙ");
                Console.WriteLine("МИР\n    ТРУД\n\t МАЙ");
                Console.WriteLine();
                Console.ReadKey();
            }    
            static void zad14()
            {
                Console.WriteLine("14 ZADANIE.Вывод данных, снова..."); // :( NAADOELO REALY
                Console.WriteLine("2 кг\r\n13 17\r\n");
            }
            static void zad15()
            {
                Console.Write("15 ZADANIE. Рандомные числа. \n" +
                    "Введите границу x.x - Натуральное число \n" +
                    "Диапазон будет от -x до x ");
                int diapason = int.Parse(Console.ReadLine());
                for (int i = 0; i < 4; i++)
                {
                    Random newrand = new Random();
                    Console.WriteLine(newrand.Next(-diapason, diapason + 1));
                }
            }
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
            static void zad16()
            {
                Console.WriteLine("16 ZADANIE.Вычесление корней квадратного уравнения");

                Console.Write("Введите коэфицент a ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Введите коэфицент b ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Введите коэфицент c ");
                double c = double.Parse(Console.ReadLine());
                KvUrav(a, b, c);
                
            }
            static void zad20()
            {
                Console.WriteLine("20 ZADANIE.Введите количество секунд");
                long time = long.Parse(Console.ReadLine());
                int sec = (int)(time % 60);
                int min = (int)((time % 3600) / 60);
                int hours = (int)(time / 3600);
                string answer = $"{hours % 24}:{min / 10}{min % 10}:{sec / 10}{sec % 10}";
                Console.WriteLine(answer);
                Console.WriteLine();
            }
            static void zad23()
            {
                Console.WriteLine("23 ZADANIE.Введите 3-хзначное число");
                string stroka = Console.ReadLine();
                if(stroka.Length != 3)
                {
                    Console.WriteLine("Трезначное Число. Чел ты..."); //1000-7?
                }
                else
                    Console.WriteLine(stroka[2] + stroka[0] + stroka[1]);
            }
            static void zad32()
            {
                Console.Write("Введите номер арифметческой последовательности ");
                int len = int.Parse(Console.ReadLine());
                Console.Write("Введите первый член последовательности ");
                double first = double.Parse(Console.ReadLine());
                Console.Write("Введите второй член последовательности ");
                double second = double.Parse(Console.ReadLine());
                double k = second-first;//k - разница между первым и вторым
                Console.WriteLine($"{len}-ый номер прогрессии = {first+(k*(len-1))}");
            }
            
            static void zad34()
            {
                Console.WriteLine("Как тебя зовут? ");
                string name1 = Console.ReadLine();
                Console.WriteLine(name1);
                Console.WriteLine("Как тебя зовут? ");
                string name2 = Console.ReadLine();
                Console.WriteLine($"САЛАМ АЛЕЙКУМ, {name2} ");
                Console.ReadKey();
            }
            /*static void zad35()
            {
                Thread.Sleep(5000);
                Random rand = new Random();
                rand.Next(0,16);
                Console.BackgroundColor = ConsoleColor.rand;
                Console.Clear();
            }*/


        }
    }
}