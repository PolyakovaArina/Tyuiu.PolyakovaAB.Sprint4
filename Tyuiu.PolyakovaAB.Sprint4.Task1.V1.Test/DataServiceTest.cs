using Tyuiu.PolyakovaAB.Sprint4.Task1.V1.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] a = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };
            Assert.AreEqual(14, ds.Calculate(a));
        }
    }
}
