using System.Runtime.CompilerServices;
using Tyuiu.PolyakovaAB.Sprint4.Task1.V1.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            int b;
            Console.Title = "Спринт #4 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
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
                Console.Write("Введите " + i + " символ: ");
                y = Convert.ToInt32(Console.ReadLine());
                a[i] = y;
            }
            Console.WriteLine("* Массив:                                                                 *");
            for (int i = 0; i<b; i++)
            {
                Console.Write(a[i] + "\t");
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
