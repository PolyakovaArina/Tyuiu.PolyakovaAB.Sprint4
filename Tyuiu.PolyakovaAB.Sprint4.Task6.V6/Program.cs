using Tyuiu.PolyakovaAB.Sprint4.Task6.V6.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Полякова Арина Вячеславовна | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, находит слова из 5 букв                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив:                                                                 *");
            string[] a = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} \t");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] b = (ds.Calculate(a));
            for (int i = 0;i < b.Length; i++)
            {
                Console.Write($"{b[i]} \t");
            }
            Console.ReadKey();
        }
    }
}
