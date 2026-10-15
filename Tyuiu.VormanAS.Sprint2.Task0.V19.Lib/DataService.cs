using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VormanAS.Sprint2.Task0.V19.Lib
{
    public class DataService : ISprint2Task0V19
    {
        public bool[] GetCompareOperations(int x, int y)
        {

            bool[] res = new bool[6];

            //x = 105; y = 177

            res[0] = x + 72 == y; //True
            res[1] = x != y; //True
            res[2] = x < y; //True
            res[3] = x + 80 > y; //True
            res[4] = x + 72 <= y; //True
            res[5] = x + 73 >= y; //True

            return res;
        }
    }
}
