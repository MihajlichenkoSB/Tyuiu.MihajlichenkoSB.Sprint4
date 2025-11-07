using Tyuiu.MihajlichenkoSB.Sprint4.Task6.V23.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint4.Task6.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #Х                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан строковый массив данных [\"Microsoft\", \"Google\", \"Apple\", \"Amazon\",   *");
            Console.WriteLine("* \"Facebook\", \"Tesla\", \"Netflix\"]. Используя класс Array подсчитайте      *");
            Console.WriteLine("* количество элементов, длина которых равна 6.                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string[] stringArray = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            Console.WriteLine("Исходный массив строк:");
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(stringArray);

            Console.WriteLine($"Количество элементов с длиной 6: {res}");
            Console.ReadKey();
        }
    }
}
