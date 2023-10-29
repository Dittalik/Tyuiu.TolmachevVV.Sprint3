using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TolmachevVV.Sprint3.Task4.V24.Lib
{
    public class DataService : ISprint3Task4V24
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if(x == 0)
                {
                    break;
                }
                y *= (Math.Sin(x) / x) + 2;
            }
            return Math.Round(y, 3);
        }
    }
}
