using Tyuiu.ShakinVV.Sprint2.Task6.V13.Lib;

namespace Tyuiu.ShakinVV.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("16.05.2026", ds.FindDateOfNextDay(2026, 5, 15));
            Assert.AreEqual("01.03.2024", ds.FindDateOfNextDay(2024, 2, 29));
            Assert.AreEqual("01.05.2026", ds.FindDateOfNextDay(2026, 4, 30));
            Assert.AreEqual("01.01.2027", ds.FindDateOfNextDay(2026, 12, 31));

        }

        [TestMethod]
        public void InvalidGetNextDate()
        {
            DataService ds = new DataService();
            Assert.Throws<ArgumentException>(() => ds.FindDateOfNextDay(2026, 2, 30));
            Assert.Throws<ArgumentException>(() => ds.FindDateOfNextDay(2026, 13, 1));
        }
    }
}
