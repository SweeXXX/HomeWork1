using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Введите иимя)) ");
            string name = Console.ReadLine();
            Console.WriteLine($"Privet, {name}");
            // 2 ZADACA
            Console.Write("Введите число 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число 2");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 != 0)
                Console.Write(num1 / num2);
            else
                Console.WriteLine("NA ZERO DELIT NELIZYA");
            // 3 ZADACA
            Console.Write("Введите символ ");
            var bukva = Console.ReadLine();
            Console.WriteLine("Следующая буква " + bukva++);
            // 4 zadaca*/
            Console.Write("Введите коэфицент a ");
            double a = double.Parse(Console.ReadLine());    
            Console.Write("Введите коэфицент b ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите коэфицент c ");
            double c = double.Parse(Console.ReadLine());
            double des = (b * b) - 4 * a * c;
            if (a != 0)
            {
                Console.WriteLine($"x1 = {(-b + Math.Sqrt(des)) / 2}");
                Console.Write($"x2 = {(-b - Math.Sqrt(des)) / 2}");
            }
            else
                Console.WriteLine($"x = {-c / b}");


        }
        
            
    }
}