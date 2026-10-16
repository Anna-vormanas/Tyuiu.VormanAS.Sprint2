using Tyuiu.VormanAS.Sprint2.Task2.V12.Lib;

namespace Tyuiu.VormanAS.Sprint2.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadeArea()
        {
            DataService ds = new DataService();

            int x = 5;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
