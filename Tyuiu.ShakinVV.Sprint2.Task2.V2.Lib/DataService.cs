using tyuiu.cources.programming.interfaces.Sprint2;

//(x >= 3 && x <= 5 && y >= 3 && y <= 6)

namespace Tyuiu.ShakinVV.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            bool block1 = (x >= 5 && x <= 10 && y >= 5 && y <= 6);
            bool block2 = (x >= 3 && x <= 4 && y >= 6 && y <= 7);
            bool block3 = (x >= 9 && x <= 10 && y >= 3 && y <= 9);
            bool block4 = (x >= 8 && x <= 12 && y >= 7 && y <= 9);
            bool block5 = (x >= 12 && x <= 13 && y >= 6 && y <= 8);
            bool block6 = (x >= 8 && x <= 9 && y >= 10 && y <= 11);
            bool block7 = (x >= 4 && x <= 7 && y >= 11 && y <= 13);
            bool line1 = (x >= 3 && x <= 5 && y == 3);
            bool line2 = (x == 12 && y >= 3 && y <= 5);
            bool solo = ((x == 7 && y == 9) || (x == 3 && y == 11) || (x == 5 && y == 4));

            if (block1 || block2 || block3 || block4 || block5 || block6 || block7 || line1 || line2 || solo)
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
