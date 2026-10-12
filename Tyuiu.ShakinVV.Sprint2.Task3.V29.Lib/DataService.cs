using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShakinVV.Sprint2.Task3.V29.Lib
{
    public class DataService : ISprint2Task3V29
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {

                y = (x * (Math.Pow((x + 1) / (x - 1), 5)));

            }
            else
            {
                if (x == 0)
                {

                    y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 6) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) +5); 

                }
                else
                {
                    if (x < 2 && -33 < x)
                    {

                        y = (Math.Pow(1 + 1.0 / (Math.Pow(x, 2)), x));

                    }
                    else
                    {
                        if (x < -33)
                        {

                            y = (x + 10.0 * x - (1.0/x));

                        }
                    }
                }
            }

            return (Math.Round(y, 3));
        }
    }
}
