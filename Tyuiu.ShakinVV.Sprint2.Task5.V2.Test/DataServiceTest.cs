using Tyuiu.ShakinVV.Sprint2.Task5.V2.Lib;

namespace Tyuiu.ShakinVV.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();

            
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));   
            Assert.AreEqual("Весна", ds.FindMonthSeason(4));  
            Assert.AreEqual("Лето", ds.FindMonthSeason(7));   
            Assert.AreEqual("Осень", ds.FindMonthSeason(10)); 

            Assert.Throws<ArgumentException>(() => ds.FindMonthSeason(0));
            Assert.Throws<ArgumentException>(() => ds.FindMonthSeason(13));



        }
    }
}
