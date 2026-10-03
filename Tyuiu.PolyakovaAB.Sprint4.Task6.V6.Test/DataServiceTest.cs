using Tyuiu.PolyakovaAB.Sprint4.Task6.V6.Lib;
namespace Tyuiu.PolyakovaAB.Sprint4.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string[] a = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] s = { "Борис", "Ирина" };
            CollectionAssert.AreEqual(s, ds.Calculate(a));
        }
    }
}
