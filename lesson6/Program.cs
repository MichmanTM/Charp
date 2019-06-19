 // Бутенко Михаил  д\з к 6-уроку, задача 1.
 //Изменить программу вывода таблицы функции так, 
 //чтобы можно было передавать функции типа double (double, double).
 //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork61
{
    public delegate double Fun(double x);
    class Program
    {
        // Создаем метод, который принимает делегат
        // То есть на практике, этот метод сможет принимать любой метод
        // с такой же сигнатурой как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double Sinus(double x, double a)
        {
            return a * Math.Sin(x);
        }
        static void Main()
        {
            int a= 5;
            Console.WriteLine("Таблица функции a*x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return a * x * x; }, 0, 3);
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(delegate (double x) { return a * Math.Sin(x); }, 0, 3);
            Console.ReadLine();

        }

    }



    
}

