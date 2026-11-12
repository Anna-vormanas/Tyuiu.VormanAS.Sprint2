using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VormanAS.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 29,
                _ => 0
            };

            int nextN = n + 1;
            int nextM = m;
            int nextG = g;

            if (nextN > daysInMonth)
            {
                nextN = 1;
                nextM++;
                if (nextM > 12)
                {
                    nextM = 1;
                    nextG++;
                }
            }

            string res = string.Format("{0:D2}.{1:D2}.{2:D4}", nextN, nextM, nextG);

            return res;
        }
    }
}
