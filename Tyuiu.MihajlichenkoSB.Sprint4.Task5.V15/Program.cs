using Tyuiu.MihajlichenkoSB.Sprint4.Task5.V15.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         *");
            Console.WriteLine("* случайными значениями в диапазоне от -6 до 4. Найти сумму положительных  *");
            Console.WriteLine("* элементов массива.                                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int rows = 5;
            int columns = 5;
            int[,] array = new int[rows, columns];

            Console.WriteLine($"Размерность массива: {rows}x{columns}");
            Console.WriteLine("Генерация случайных чисел в диапазоне от -6 до 4:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rnd.Next(-6, 5); 
                }
            }

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine($"Сумма положительных элементов массива: {res}");
            Console.ReadKey();
        }
    }
}
