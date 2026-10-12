using Tyuiu.ShakinVV.Sprint2.Task4.V30.Lib;

//Написать программу, которая вычисляет требуемое значение сс использованием тернарного оператора, где пользователь вводит значение x,y с клавиатуры, если x * 2 > y, то z = (6 + 4/x^2)^y, иначе y + (2/x^2)

namespace Tyuiu.ShakinVV.Sprint2.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition0()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
