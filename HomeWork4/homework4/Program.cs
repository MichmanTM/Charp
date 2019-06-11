using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)                                  
        {
            MyArray myArray = new MyArray(20, -10_000, 10_000);            //задаем параметры метода MyArray  
            Console.WriteLine( myArray.ToString()   );                    //выводим перемееную 
            myArray.Divisibility3();                                       // выполняем действие с переменной при помощи метода
            Console.ReadLine();
        }
    }
    public class MyArray
    {
        private  int[] b;                                               //обьевляем масив

        public MyArray(int n, int min, int max)                          //создаем метод
        {
            b = new int[n];                                             //инициализируем масив
            Random random = new Random();                               //создаем переменную random и инициализируем ее
            for (int i = 0; i < n; i++)                                       
                b[i] = random.Next(min, max);                                //заполняем масив

        }
        public int Divisibility3()                                                              //создаем метод проверки числа и и находим пары чисел
        {
            int count = 0;
            for (int i = 0; i<b.Length - 1; i++)
            {
                if (b[i] % 3 == 0 || b[i+1] % 3 == 0)
                    count++;
                Console.WriteLine("пара чисел:  {0} и {1}" , b[i], b[i+1]);

            }
            Console.WriteLine($"количество пар:" + count);
            return count;
        }
        override public string ToString()
        {                                                                                       
            string stringarray = "";
            foreach (int x in b)
            
                stringarray = stringarray + x + "  ";
            

            return stringarray;
        }
    }
           
        
    
}
