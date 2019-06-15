using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace homeWork51                       // Бутенко Михаил 
                                          //Создать программу, которая будет проверять корректность ввода логина.
                                          //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
                                          //при этом цифра не может быть первой:
                                          //  а) без использования регулярных выражений;
                                          //  б) ** с использованием регулярных выражений.
{

    class Program
    {
        static void Main(string[] args)
        {
            #region задача №1 а)

            string source = "ivanov98";

            // Проверка на длину
            if (source.Length < 2 || source.Length > 10)
            {
                Console.WriteLine("Login is incorrect");
            }

            // Проверка первого символа на цифру
            if (!Char.IsDigit(source[0]))
            {
                Console.WriteLine("Login is incorrect");
            }

            bool correct = true;

            for (int i = 0; i < source.Length; i++)
            {
                if (!Char.IsLetterOrDigit(source[i]))
                {
                    correct = false;
                    break;
                }
            }

            if (correct)
            {
                Console.WriteLine("Login is correct");
            }
            else
            {
                Console.WriteLine("Login is incorrect");
            }
            Console.ReadKey();

            #endregion 

            #region задача №1 б)


            Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            string source1 = "ivanov98";

            if (login_regex.Match(source1).Success) // если совпадение удачно
            {
                Console.WriteLine("Login is correct");
            }
            else
            {
                Console.WriteLine("Login is incorrect");
            }


            Console.ReadKey();

            #endregion

        }


    }
}
