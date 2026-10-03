using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PolyakovaAB.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] a  = new int[n, m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m;j++)
                {
                    a[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int c = 1;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i,j] % 2 == 0)
                    {
                        c *= a[i, j];
                    }
                }
            }
            return c;
        }
    }
}
