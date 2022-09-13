using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Home
{
    class Proga
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("1 ZADANIE. chislo E");
            Console.WriteLine(Math.Round(Math.E,1));
            Console.WriteLine();

            Console.WriteLine("2 ZADANIE");
            Console.WriteLine(50);
            Console.WriteLine(10);
            Console.WriteLine();

            Console.Write("3 ZADANIE. Введите 4 числа через пробел ");
            var numbers = (Console.ReadLine()).Split();
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            Console.Write("4 ZADANIE. (Добавить 10) Введите число ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine(num4 + 10);
            Console.WriteLine();

            Console.Write("5 ZADANIE. Введите сторону квадрата ");
            int storona_kvadrata = int.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр Квадрата = {storona_kvadrata*4}");
            Console.WriteLine();

            Console.WriteLine("6 ZADANIE. Введите радиус окружности");
            double rad = double.Parse(Console.ReadLine());
            Console.WriteLine($"Длина окружности = {Math.Round(2*Math.PI*rad,4)}. Площадь круга = {Math.Round(Math.PI*rad*rad,4)}");
            Console.WriteLine();*/

            Console.Write("7 ZADANIE. Вычисляем cos(x). Введите x ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Cos(x));
            Console.WriteLine();

            Console.Write("8 ZADANIE. Введите 3 числа через пробел: " +
                "1 основание, 2 основание, высоту трапеции ");
            var spisok = Console.ReadLine().Split();
            double FOsnov = double.Parse(spisok[0]);
            double SOsnov = double.Parse(spisok[1]);
            double height = double.Parse(spisok[2]);
            double BStorona = Math.Sqrt(Math.Pow(Math.Abs(FOsnov-SOsnov)/2,2)+height*height);
            Console.WriteLine($"Периметр = {2*BStorona+FOsnov+SOsnov}");
            Console.WriteLine();

            Console.Write("9 ZADANIE."+
                "Введите количество кг конфет, печенья, яблок по порядку.Через пробел ");
            double[] cousts = { 2, 2, 2 };// в задание сказано было, что цены даны. поэтому я сделал так))
            var xyz = Console.ReadLine().Split();// cousts это цены за кг. первое число это , второе печенье, а 3 яблоки
            double[] doublexyz = new double[3];
            double sum = 0;
            for (int i = 0; i < xyz.Length; i++)
            {
                doublexyz[i] = double.Parse(xyz[i]);
                sum += doublexyz[i] * cousts[i];
            }
            Console.WriteLine($"Общая сумма = {sum}");


            Console.WriteLine("10 ZADANIE. PEACE WORK MAY");
            Console.WriteLine("МИР ТРУД МАЙ");
            Console.WriteLine("МИР\n    ТРУД\n\t МАЙ");
            Console.WriteLine();
        }
    }
}