using Tyuiu.VormanAS.Sprint2.Task5.V15.Lib;

namespace Tyuiu.VormanAS.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            int k = 1;
            var res = ds.FindDayName(k);
            string wait = "Понедельник";

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            int k = 4;
            var res = ds.FindDayName(k);
            string wait = "Четверг";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();

            int k = 7;
            var res = ds.FindDayName(k);
            string wait = "Воскресенье";

            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            int k = 100;
            var res = ds.FindDayName(k);
            string wait = "Вторник";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition5()
        {
            DataService ds = new DataService();

            int k = 365;
            var res = ds.FindDayName(k);
            string wait = "Понедельник";

            Assert.AreEqual(wait, res);
        }
    }
}
