using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShakinVV.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                4 => 30,
                6 => 30,
                9 => 30,
                11 => 30,
                2 => 29,
                1 => 31,
                3 => 31,
                5 => 31,
                7 => 31,
                8 => 31,
                10 => 31,
                12 => 31,
                _ => throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}")
            };
            if (n < 1 || n > daysInMonth || g < 1)
            {
                throw new ArgumentException("Некорректный день или год.");
            }
            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                if (m < 12)
                {
                    m++;
                }
                else
                {
                    m = 1;
                    g++;
                }
            }
            return $"{n:D2}.{m:D2}.{g:D4}";
        }
    }
}