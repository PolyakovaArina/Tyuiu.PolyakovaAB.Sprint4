using Tyuiu.PolyakovaAB.Sprint4.Task4.V13.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] a = { { 1, 2, 3 }, { 3, 6, 6 } };
            Assert.AreEqual(14, ds.Calculate(a));
        }
    }
}
