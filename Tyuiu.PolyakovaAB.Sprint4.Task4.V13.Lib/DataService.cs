using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PolyakovaAB.Sprint4.Task4.V13.Lib
{
    public class DataService : ISprint4Task4V13
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int p = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        p += array[i,j];
                    }
                }
            }
            return p;
        }
    }
}
