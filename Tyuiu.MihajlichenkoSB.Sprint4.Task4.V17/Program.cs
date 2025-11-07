using Tyuiu.MihajlichenkoSB.Sprint4.Task4.V17.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный          *");
            Console.WriteLine("* случайными в диапазоне от 1 до 7 подсчитать произведение четных          *");
            Console.WriteLine("* элементов массива.                                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите количество строк в массиве:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество строк в массиве:");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("****************************************************************************");


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i}, {j} элемент массива: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine();
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    Console.WriteLine($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(matrix);

            Console.WriteLine("кол-во 0-х элементов =" + res);
            Console.ReadKey();
        }
    }
}
