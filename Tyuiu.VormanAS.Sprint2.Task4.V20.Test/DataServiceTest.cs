using Tyuiu.VormanAS.Sprint2.Task4.V20.Lib;

namespace Tyuiu.VormanAS.Sprint2.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 5;
            double y = 3;
            var res = ds.Calculate(x, y);
            double wait = 5.000;

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 1;
            var res = ds.Calculate(x, y);
            double wait = 8.000;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 10;
            var res = ds.Calculate(x, y);
            double wait = 8.900;

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 10;
            var res = ds.Calculate(x, y);
            double wait = -0.100;

            Assert.AreEqual(wait, res);
        }
    }
}
