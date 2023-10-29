using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TolmachevVV.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res[count] = Math.Round((5 * i + 2.5) / (Math.Sin(i) + 3) + 2 * i + Math.Cos(i), 2);
                count++;
            }
            return res;
        }
    }
}
