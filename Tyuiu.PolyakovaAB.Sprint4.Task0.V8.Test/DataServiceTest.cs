using Tyuiu.PolyakovaAB.Sprint4.Task0.V8.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 1, 6,3, 7, 5, 4, 2, 7, 8, 9 };
            Assert.AreEqual(384, ds.GetMultEvenArrEl(a));
        }
    }
}
