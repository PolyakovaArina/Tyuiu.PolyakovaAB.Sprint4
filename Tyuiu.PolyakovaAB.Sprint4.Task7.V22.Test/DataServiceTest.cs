using Tyuiu.PolyakovaAB.Sprint4.Task7.V22.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "112345";
            Assert.AreEqual(8, ds.Calculate(2, 3, a));
        }
    }
}
