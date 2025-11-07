using Tyuiu.MihajlichenkoSB.Sprint4.Task1.V9.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint4.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный          *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8 подсчитать произведение    *");
            Console.WriteLine("* четных элементов массива.  С клавиатуры: 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8*");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int len;

            Console.WriteLine("Введите количество элементов массива:");

            len = Convert.ToInt32(Console.ReadLine());

            int[] namsArray = new int[len];

            for (int i = 0; i < len - 1; i++) 
            {
                Console.WriteLine("Введите значение" + i + "элемента массива: ");
                namsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("массив: ");
            for (int i = 0; i < len - 1; i++) 
            { 
                Console.WriteLine(namsArray[i] + "\t");

            }
            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(namsArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
