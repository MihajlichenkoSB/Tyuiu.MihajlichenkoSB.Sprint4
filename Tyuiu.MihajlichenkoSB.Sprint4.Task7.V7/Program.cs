using System;
using Tyuiu.MihajlichenkoSB.Sprint4.Task7.V7.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Дополнительное задание                                             *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"31415926\". Преобразуйте ее в матрицу *");
            Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.                  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int n = 4; 
            int m = 2; 
            string str = "31415926";

            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Размерность матрицы: {n}x{m}");


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine($"Количество нечетных чисел в матрице: {res}");
            Console.ReadKey();
        }
    }
}
