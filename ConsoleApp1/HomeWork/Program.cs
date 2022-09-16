using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
            zad1();
            zad2();
            zad3();
            zad4();
            zad5();
            zad6();
            zad7();
            zad8();
            zad9();
            zad10();
            zad11();
            //zad12();
            zad13();
            zad14();
            zad15();
            zad16();
            zad17();
            zad18();
            zad19();
            zad20();
            zad21();
            zad22();
            zad23();
            zad24();
            zad25();
            zad26();
            //zad27();
            zad28(9);
            zad30();
            zad31();
            zad32();
            //zad33();
            zad34();
            zad35();
            //zad36();
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
            static void zad11()
            {

                Console.WriteLine("11 ZADANIE. Ввод 2 чисел");
                Console.Write("Введите первое число ");
                string str1 = Console.ReadLine();
                str1 = str1.Replace(".",",");
                bool num1 = double.TryParse(str1, out var res1);

                Console.Write("Введите второе число ");
                string str2 = Console.ReadLine();
                str2 = str2.Replace(".", ",");
                bool num2 = double.TryParse(str2, out var res2);

                if (num1 && num2)
                    Console.WriteLine($"{str2}\n{str1}");
                else
                    Console.WriteLine("Просили ввести число))))))))))))))");
            }
            static void zad13()
            {
                Console.WriteLine("13 ZADANIE. Вывод числа");
                Console.Write("Введите число ");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"Вы ввели число {num}\n") ;
            }
            static void zad14()
            {
                Console.WriteLine("14 ZADANIE.Вывод данных, снова..."); // :( NAADOELO REALY
                Console.WriteLine("2 кг\r\n13 17\r\n");
                Console.ReadKey();
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
                Console.WriteLine("\n");
            }
            static void zad17()
            {
                Console.Write("17 ZADANIE.Среднее арифметическое и геометрическое.\nВведите 2 целых числа через пробел ");
                string[] input = Console.ReadLine().Split();
                if(input.Length == 2)
                {
                    int num1 = int.Parse(input[0]);
                    int num2 = int.Parse(input[1]);
                    Console.WriteLine($"Среднее арифметическое = {(double)(num1+num2)/2}\nСреднее геометрическое = {(double)Math.Sqrt(num1*num2)}.\n");
                }

            }
            static void zad18()
            {
                Console.Write("18 ZADANIE.\nВведите координаты (x,y) первой точки через пробел! ");
                string[] koor1 = Console.ReadLine().Split();
                double x1 = double.Parse(koor1[0]);
                double y1 = double.Parse(koor1[1]);
                Console.Write("Введите координаты (x,y) второй точки через пробел! ");
                string[] koor2 = Console.ReadLine().Split();
                double x2 = double.Parse(koor2[0]);
                double y2 = double.Parse(koor2[1]);
                Console.WriteLine($"Расстояние между двумя точками = {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}\n");
                Console.ReadKey();
            }
            static void zad19()
            {
                Console.WriteLine("19 ZADANIE.Замена переменных");
                int a = 1;
                int b = 2;
                int с = 3;
                int t = a;
                Console.WriteLine($"a = {a} b = {b} c = {с}");
                t = b;
                b = с;
                с = a;
                a = t;
                Console.WriteLine($"А: a = {a} b = {b} c = {с}");
                a = 1;
                b = 2;
                с = 3;
                t = a;
                t = b;
                b = a;
                a = с;
                с = t;
                Console.WriteLine($"Б: a = {a} b = {b} c = {с}");
            }
            static void zad20()
            {
                Console.Write("20 ZADANIE.Введите количество секунд ");
                long time = long.Parse(Console.ReadLine());
                int sec = (int)(time % 60);
                int min = (int)((time % 3600) / 60);
                int hours = (int)(time / 3600);
                string answer = $"{hours % 24}:{min / 10}{min % 10}:{sec / 10}{sec % 10}";
                Console.WriteLine(answer);
                Console.WriteLine();
            }
            static void zad21(int a=1)
            {
                int lenKv = 130;
                int st1 = 543; 
                int st2 = 130;
                Console.WriteLine($"21 ZADANIE.\nСколько квадратов со стороной {lenKv} поместиться в прямоугольник размером {st1}х{st2}? ");
                Console.ReadKey();
                Console.WriteLine($"Ответ убил: {(int)(st1*st2/(lenKv*lenKv))}.\n");
                Console.ReadKey();
            }
            static void zad22()
            {
                Console.WriteLine("22 ZADANIE.Введите 3-хзначное число");
                string stroka = Console.ReadLine();
                if(stroka.Length != 3)
                {
                    Console.WriteLine("Трезначное Число. Чел ты...\n"); //1000-7?
                }
                else
                    Console.WriteLine($"{stroka[2]}{stroka[0]}{stroka[1]}\n");
            }
            static void zad23()
            {
                Console.Write("23ZADANIE. Введите число большее 999 ");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"Количество сотен = {(int)number/100}.\nКоличество тысяч = {(int)number/1000}.\n");
            }
            static void zad24()
            {
                Console.Write("24 ZADANIE.Введите 4-значное число ");
                string str = Console.ReadLine();
                string res1 = $"{str[3]}{str[2]}{str[1]}{str[0]}";
                int num1 = int.Parse(res1);
                string res2 = $"{str[1]}{str[0]}{str[3]}{str[2]}";
                int num2 = int.Parse(res2);
                string res3 = $"{str[0]}{str[2]}{str[1]}{str[3]}";
                int num3 = int.Parse(res3);
                string res4 = $"{str[2]}{str[3]}{str[0]}{str[1]}";
                int num4 = int.Parse(res4);
                Console.WriteLine($"{num1}, {num2}, {num3}, {num4}\n");
            }
            static void zad25()
            {
                Console.WriteLine("25 ZADANIE.Из трехзначного числа x вычли его последнюю цифру.");
                Console.Write("Введите число ");
                string input = Console.ReadLine();
                if ((int.Parse(input) % 100) / 10 != 0)
                    Console.WriteLine("x = " + input[1] + input[2] + input[0]);
                else
                    Console.WriteLine("Число десятков не должно равняться нулю...");
            }
            static void zad26()
            {
                Console.WriteLine("26 ZADANIE.");
                Console.Write("Введите часы, минуты, секунды через пробел ");
                string[] time = Console.ReadLine().Split();
                int hours = int.Parse(time[0]);
                int min = int.Parse(time[1]);
                int sec = int.Parse(time[2]);
                if (hours >= 12)
                {
                    hours -= 12;
                }
                Console.WriteLine($"Угол между стрелками = {((360 / 12) * hours + (0.5 * min) + (0.0083 * sec))}");

            }
            static void zad28(int a = 9)
            {
                Console.Write("28 ZADANIE.Меньшее по модулю.Сумма большего и меньшего.\nВведите первое число ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число ");
                double num2 = double.Parse(Console.ReadLine());
                Console.Write("Введите третье число ");
                double num3 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Минимальное по модулю число = {Math.Min(num1, Math.Min(num2,num3))}\n");
                if(a==9)
                    Console.WriteLine($"29 ZADANIE.Сумма большего и меньшего числа = {Math.Min(num1, Math.Min(num2, num3))+ Math.Max(num1, Math.Max(num2, num3))}\n");
            }
            static void zad30()
            {
                Console.Write("30 ZADANIE.Количество натуральных делителей.\nВведите число ");
                int num = int.Parse(Console.ReadLine());
                int count = 0;
                int k = 1;
                while(k*k<num)
                {
                    if(num%k == 0)
                    {
                        count++;
                    }
                    k++;
                }
                Console.WriteLine($"Количество натуральных делителей = {count*2}\n");
            }
            static void zad31()
            {
                Console.WriteLine("31 ZADANIE.Куб. урав.");
                Console.WriteLine("введите коэффициенты уравнения (a,b,c,d) через пробел");
                int[] coef = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
                int count = 0;
                for (int i = -100; i <= 100; i++)
                {
                    double result = coef[0] * Math.Pow(i, 3) + coef[1] * i * i + coef[2] * i + coef[3];
                    if (result == 0)
                    {
                        Console.WriteLine($"X = {i}");
                        count++;
                    }
                }
                if (count == 0)
                    Console.WriteLine("Корней нет((\n");
            }
            static void zad32()
            {
                Console.Write("32 ZADANIE.Введите номер элемента арифметческой последовательности ");
                int len = int.Parse(Console.ReadLine());
                Console.Write("Введите первый член последовательности ");
                double first = double.Parse(Console.ReadLine());
                Console.Write("Введите второй член последовательности ");
                double second = double.Parse(Console.ReadLine());
                double k = second-first;//k - разница между первым и вторым
                Console.WriteLine($"{len}-ый номер прогрессии = {first+(k*(len-1))}");
            }
            /*static void zad33()
            {
                Console.Write("Кто ты, воин? Ты студент? ");
                string input = Console.ReadLine();
                Console.Write("Ты трудоустроен? ");
                string work = Console.ReadLine();
            }*/
            
            static void zad34()
            {
                Console.WriteLine("34 ZADANIE.");
                Console.Write("Как тебя зовут? ");
                string name1 = Console.ReadLine();
                Console.WriteLine(name1);
                Console.Write("Как тебя зовут? ");
                string name2 = Console.ReadLine();
                Console.WriteLine($"САЛАМ АЛЕЙКУМ, {name2} ");
                Console.ReadKey();
            }
            static void zad35()
            {
                Console.WriteLine("35 ZADANIE.Тайная комната.");
                Random color = new Random();
                Console.ReadLine();
                Console.WriteLine("Как тебя зовут?");
                string name3 = Console.ReadLine();
                Console.WriteLine($"Привет, {name3}");
                Console.ReadLine();
                Console.WriteLine("Да");
                Console.ReadLine();
                Console.WriteLine("Нет");
                Thread.Sleep(5000);
                Console.WriteLine("Но могу показать");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                int color1 = color.Next(0, 16);
                if (color1 == 0)
                    Console.BackgroundColor = ConsoleColor.Black;
                if (color1 == 1)
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                if (color1 == 2)
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                if (color1 == 3)
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                if (color1 == 4)
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                if (color1 == 5)
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                if (color1 == 6)
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                if (color1 == 7)
                    Console.BackgroundColor = ConsoleColor.Gray;
                if (color1 == 8)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                if (color1 == 9)
                    Console.BackgroundColor = ConsoleColor.Blue;
                if (color1 == 10)
                    Console.BackgroundColor = ConsoleColor.Green;
                if (color1 == 11)
                    Console.BackgroundColor = ConsoleColor.Cyan;
                if (color1 == 12)
                    Console.BackgroundColor = ConsoleColor.Red;
                if (color1 == 13)
                    Console.BackgroundColor = ConsoleColor.Magenta;
                if (color1 == 14)
                    Console.BackgroundColor = ConsoleColor.Yellow;
                if (color1 == 15)
                    Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
}