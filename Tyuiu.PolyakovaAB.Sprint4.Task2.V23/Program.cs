using Tyuiu.PolyakovaAB.Sprint4.Task2.V23.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random r = new Random();
            int b;
            Console.Title = "Спринт #4 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Полякова Арина Вячеславовна | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая считает сумму четных элементов массива       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("* Введите размер массива: ");
            b = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[b];
            int y;
            for (int i = 0; i < b; i++)
            {
                a[i] = r.Next(3, 9);
            }
            Console.WriteLine("* Массив:                                                                 *");
            for (int i = 0; i < b; i++)
            {
                Console.Write(a[i] + "    ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(a));
            Console.ReadKey();
        }
    }
}
