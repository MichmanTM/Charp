using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
   class Complex
        {
            // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
            public double im;
            public double re;

        public Complex(double Re, double Im)
        {
            re = Re;
            im = Im;
        }

        public Complex(double arg)
        {
            re = arg;
            im = arg;
        }

        public Complex sum(Complex Z, Complex Z1)
        {
            return new Complex(Z.re + Z1.re, Z.im + Z1.im);
        }

        public Complex sub(Complex Z, Complex Z1)
        {
            return new Complex (Z.re - Z1.re, Z.im - Z1.im);
        }

        public Complex multi(Complex Z, Complex Z1)
        {
            return new Complex(Z.re * Z1.re, Z.im * Z1.im);
        }

        public string ToString1()
        {
            return $"{re} + {im}i";
        }
    }
    class Program
    {
        public static void Pause()
        {
            Console.ReadKey();
        }


            static void Main(string[] args)
            {
            #region  д.з-1(a,б)
            //Complex z = new Complex(10, 40);
            //Console.WriteLine(z.ToString1());

            //Complex z1 = new Complex(30);
            //Console.WriteLine(z1.ToString1());

            //Console.WriteLine($"Сумма");
            //Complex z2 = z.sum(z, z1);
            //Console.WriteLine(z2.ToString1());

            //Console.WriteLine($"Разность");
            //Complex z3 = z.sub(z, z1);
            //Console.WriteLine(z3.ToString1());

            //Console.WriteLine($"Произведение");
            //Complex z4 = z.multi(z, z1);
            //Console.WriteLine(z4.ToString1());
            //Pause();

            #endregion

            #region  д.з-1(в)
            //Console.WriteLine($"Даны два комплексных числа");
            //Complex z = new Complex(10, 40);
            //Console.WriteLine(z.ToString1());

            //Complex z1 = new Complex(30);
            //Console.WriteLine(z1.ToString1());
            //Console.WriteLine($"какое десйствие хотите выполнить?\n введитк (1) если сложить, (0) если вычесть, (-1) если умножить.");
            //string b = Console.ReadLine();
            //switch (b)
            //{
            //    case "-1":
            //        Complex z4 = z.multi(z, z1);
            //        Console.WriteLine(z4.ToString1());
            //        break;
            //    case "0":
            //        Complex z3 = z.sub(z, z1);
            //        Console.WriteLine(z3.ToString1());
            //        break;
            //    case "1":
            //        Complex z2 = z.sum(z, z1);
            //        Console.WriteLine(z2.ToString1());
            //        break;

            //}

            //Pause();
            #endregion

            #region  д.з-2

            
            //int num = 0;
            //int sum = 0;
            
            //do
            //{
            //    int.TryParse(Console.ReadLine(), out num);

            //    if (num > 0 && num % 2 == 1)
            //    {

            //        sum += num;
       
            //    }

            //} while (num != 0);

            //      Console.WriteLine("Sum: " + sum);

            //     Pause();
            #endregion






           


            

        }
    }
}
