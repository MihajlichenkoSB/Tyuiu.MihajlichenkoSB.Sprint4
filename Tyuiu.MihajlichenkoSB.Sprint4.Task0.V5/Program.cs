using Tyuiu.MihajlichenkoSB.Sprint4.Task0.V5.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task0.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму           *");
            Console.WriteLine("* четных элементов массива.  {8, 9, 4, 1, 2, 3, 4, 5, 6 ,7}                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Результатирующий массив");

            int sumEven = ds.GetSumEvenArrEl(numsArray); 
            Console.WriteLine("Сумма четных элементов: " + sumEven);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
