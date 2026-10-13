using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShakinVV.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (x >= 0 && y >= 0 && y <= 4 && y <= x * x)
            {

                res = true;

            }
            else
            {

                res = false;

            }
            return res;
        }
    }
}
