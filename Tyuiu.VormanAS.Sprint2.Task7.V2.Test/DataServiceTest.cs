using Tyuiu.VormanAS.Sprint2.Task7.V2.Lib;

namespace Tyuiu.VormanAS.Sprint2.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = -0.5;
            var res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 0.8;
            double y = 0.4;
            var res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.5;
            var res = ds.CheckDotInShadedArea(x, y);

            Assert.IsFalse(res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = 1.5;
            double y = 0;
            var res = ds.CheckDotInShadedArea(x, y);

            Assert.IsFalse(res);
        }

        [TestMethod]
        public void ValidCondition5()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 0;
            var res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);
        }
    }
}
