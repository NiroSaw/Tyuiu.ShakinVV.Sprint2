using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один 
//раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также 
//арифметических выражений, которая вернет логическую последовательность(массив): (False, True, True, True, True, False), при
//a = 185, b = 216, c = 174, d = 917

namespace Tyuiu.ShakinVV.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c + 800 < d);
            res[1] = (a + 50 > b) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a + 50 > b) && (c < d);
            res[4] = (!res[0]);
            res[5] = (a + 50 > b) ^ (c < d);

            return res;
        }
    }
}
