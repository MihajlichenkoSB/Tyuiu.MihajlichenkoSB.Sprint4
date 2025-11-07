using Tyuiu.MihajlichenkoSB.Sprint4.Task2.V9.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный          *");
            Console.WriteLine("* случайными в диапазоне от 1 до 7 подсчитать произведение четных          *");
            Console.WriteLine("* элементов массива.                                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int len = 14;

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(1, 8); 
            }

            Console.WriteLine("массив: ");

            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
