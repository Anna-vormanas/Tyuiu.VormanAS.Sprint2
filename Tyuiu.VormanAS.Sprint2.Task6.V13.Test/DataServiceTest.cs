using Tyuiu.VormanAS.Sprint2.Task6.V13.Lib;

namespace Tyuiu.VormanAS.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            var res = ds.FindDateOfNextDay(2024, 2, 28);
            string wait = "29.02.2024";

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            var res = ds.FindDateOfNextDay(2024, 2, 29);
            string wait = "01.03.2024";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            var res = ds.FindDateOfNextDay(2024, 12, 31);
            string wait = "01.01.2025";

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            var res = ds.FindDateOfNextDay(2024, 4, 30);
            string wait = "01.05.2024";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition5()
        {
            DataService ds = new DataService();

            var res = ds.FindDateOfNextDay(2024, 5, 15);
            string wait = "16.05.2024";

            Assert.AreEqual(wait, res);
        }
    }
}
