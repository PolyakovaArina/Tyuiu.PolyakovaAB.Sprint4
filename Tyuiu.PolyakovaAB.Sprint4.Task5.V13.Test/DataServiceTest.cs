using Tyuiu.PolyakovaAB.Sprint4.Task5.V13.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] array = { { -1, 1 }, { 1, 2 }};
            int[,] s = { { 0, 1 }, { 1, 2 } };
            CollectionAssert.AreEqual(s,ds.Calculate(array));
        }
    }
}
