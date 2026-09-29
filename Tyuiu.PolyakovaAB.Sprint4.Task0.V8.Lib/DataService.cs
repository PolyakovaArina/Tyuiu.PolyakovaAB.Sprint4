using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PolyakovaAB.Sprint4.Task0.V8.Lib
{
    public class DataService : ISprint4Task0V8
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int p = 0;
            for (int i = 0; i <= array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    p += array[i];
                }
            }
            return p;
        }
    }
}
