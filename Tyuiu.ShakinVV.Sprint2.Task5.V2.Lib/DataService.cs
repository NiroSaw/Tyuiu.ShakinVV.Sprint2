using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShakinVV.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string res;
            switch (value)
            {
                // Декабрь, Январь, Февраль
                case 12:
                case 1:
                case 2:
                    res = "зима";
                    break;

                // Март, Апрель, Май
                case 3:
                case 4:
                case 5:
                    res = "весна";
                    break;

                // Июнь, Июль, Август
                case 6:
                case 7:
                case 8:
                    res = "лето";
                    break;

                // Сентябрь, Октябрь, Ноябрь
                case 9:
                case 10:
                case 11:
                    res = "осень";
                    break;

                default:
                    throw new ArgumentException($"Сезон должен быть определён по месяцу. Месяц {value}");
            }
            return res;
        }
    }
}
