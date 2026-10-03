using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PolyakovaAB.Sprint4.Task6.V6.Lib
{
    public class DataService : ISprint4Task6V6
    {
        public string[] Calculate(string[] array)
        {
            int f = 0;
            int l = array.Length;
            for (int i = 0; i < l; i++)
            {
                if (array[i].Length == 5)
                {
                    f++;
                }
            }
            int s = 0;
            string[] c = new string[f];
            for (int i = 0; i < l; i++)
            {
                if (array[i].Length == 5)
                {
                    c[s] = array[i];
                    s++;
                }
            }
            return c;
        }
    }
}
