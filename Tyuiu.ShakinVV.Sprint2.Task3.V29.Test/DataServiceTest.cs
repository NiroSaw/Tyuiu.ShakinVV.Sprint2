using Tyuiu.ShakinVV.Sprint2.Task3.V29.Lib;


namespace Tyuiu.ShakinVV.Sprint2.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition0()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 486;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = -32;
            double res = ds.Calculate(x);
            double wait = 0.969;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -34;
            double res = ds.Calculate(x);
            double wait = -373.971;
            Assert.AreEqual(wait, res);
        }
    }
}
