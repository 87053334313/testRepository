using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //задача 1
            Console.WriteLine("Введите число: ");
            string str =Console.ReadLine();
            int a;
            int.TryParse(str, out  a);
            if (a>7) 
            {
                Console.WriteLine("Привет");
            }
            else { 
            }
            Console.ReadKey();
            */

            //задача 2
            /*
            Console.WriteLine("Введите имя: ");
            string str = Console.ReadLine();
            if (str=="Вячеслав") 
            {
                Console.WriteLine("привет, " + str);
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
            Console.ReadKey();
            */
            //задача 3
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 15, 16, 18, 21, 25, 30 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0) Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
