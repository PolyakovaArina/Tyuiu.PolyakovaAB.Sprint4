using Tyuiu.PolyakovaAB.Sprint4.Task7.V22.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int r;
            int c;
            string s;
            Console.Title = "Спринт #4 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Полякова Арина Вячеславовна | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая находит произведение четных чисел            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cтрока:                                                                 *");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Cтолбец:                                                                *");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Cтрока массива:                                                         *");
            s = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(r, c, s));
            Console.ReadKey();
        }
    }
}
