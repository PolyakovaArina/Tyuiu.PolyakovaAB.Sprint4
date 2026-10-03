using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PolyakovaAB.Sprint4.Task5.V13.Lib
{
    public class DataService : ISprint4Task5V13
    {
        public int[,] Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] < 0)
                    {
                        array[i, j] = 0;
                    }
                }
            }
            return array;

        }
    }
}
