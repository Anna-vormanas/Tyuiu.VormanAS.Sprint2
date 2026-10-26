using Tyuiu.VormanAS.Sprint2.Task3.V5.Lib;

namespace Tyuiu.VormanAS.Sprint2.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 5;
            var res = ds.Calculate(x);
            double wait = -2.594;

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 0;
            var res = ds.Calculate(x);
            double wait = -0.083;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double x = -5;
            var res = ds.Calculate(x);
            double wait = 0.000;

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = -10;
            var res = ds.Calculate(x);
            double wait = -1100.010;

            Assert.AreEqual(wait, res);
        }
    }
}
