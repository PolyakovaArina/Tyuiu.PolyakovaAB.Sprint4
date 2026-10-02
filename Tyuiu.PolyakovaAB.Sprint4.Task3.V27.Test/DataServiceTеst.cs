using Tyuiu.PolyakovaAB.Sprint4.Task3.V27.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] a = { { 1, 2, 3 }, { 3, 6, 6 } };
            Assert.AreEqual(3, ds.Calculate(a));
        }
    }
}
