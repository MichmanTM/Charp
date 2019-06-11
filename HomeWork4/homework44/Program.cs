using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework44
{
    class MyArray
    {       

        string[] a;
        public MyArray(string filename)
        {
            StreamReader sw = new StreamReader(@"D:\file.txt");

            a = new string[2];
            for (int l = 0; l < 2; l++)
            {
                a[l] = sw.ReadLine();
                                                                     //  записываем текстовый файл в масив             
            }
            // Console.WriteLine($"a[0]={a[0]},a[1]= {a[1]}");                                             

            sw.Close();
            
        
            string[] mass = new string[2];                                                  //создаем новый масив  
            int i = 0;
            do
            {
                Console.WriteLine($" введите логин");                                   //запрашиваем у пользователя логин и пароль
                mass[0] = Console.ReadLine();
                Console.WriteLine($"введите пароль");
                mass[1] = Console.ReadLine();
                i++;
                if (i >= 3)                                  
                {
                    Console.WriteLine($" вы исчерпали попытки, попробуйте чуть позднее ");
                    return;
                }
                Console.WriteLine($"попробуйте еще раз ");
            }
            while (mass[0] != a[0] && mass[1] != a[1]);                                          //прверяем совпадает ли логин и пароль
            // while (mass != a && mass != a) ;



            Console.WriteLine("добро пожаловать ");
        }

        
        


    }
     class Program
    {
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter("D:\\file.txt");     //создаем текстовый файл м логом и паролем
            sw.WriteLine("root");
            sw.WriteLine("GeekBrains");                                             
            sw.Close();
                                                                             // Console.ReadLine();


            MyArray a = new MyArray(@"D:\file.txt");
         
            Console.ReadKey();
            
            
               
               
                
            
        }
    }
}
