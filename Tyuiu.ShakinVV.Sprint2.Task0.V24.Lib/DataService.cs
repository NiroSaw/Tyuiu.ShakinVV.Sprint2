using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
//и арифметических выражений, которая вернет логическую последовательность(массив): (True, True, False, False, True, True)
//при x = 135, y = 755


namespace Tyuiu.ShakinVV.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 620 == y;
            res[1] = x != y;
            res[2] = x + 621 < y;
            res[3] = x > y;
            res[4] = x + 620 <= y;
            res[5] = x + 620 >= y;

            return res;
        }
    }
}
