using Tyuiu.PolyakovaAB.Sprint4.Task5.V13.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random ra = new Random();

            int r;
            int c;
            Console.Title = "Спринт #4 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Полякова Арина Вячеславовна | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая отрицательные числа превращает в ноль        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("* Количество строк: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("* Количество столбцов: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] a = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = ra.Next(-2,6);
                }
            }
            Console.WriteLine("* Массив:                                                                 *");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{a[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] b = (ds.Calculate(a));
            for (int i = 0; i < r; i++)
            {
                for (int j = 0;j < c; j++)
                {
                    Console.Write($"{b[i, j]} \t");
                   
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
