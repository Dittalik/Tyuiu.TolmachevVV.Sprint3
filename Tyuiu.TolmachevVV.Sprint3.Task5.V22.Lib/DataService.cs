﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TolmachevVV.Sprint3.Task5.V22.Lib
{
    public class DataService : ISprint3Task5V22
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double y = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    y += (Math.Pow(x, 3) * Math.Sin(k)) + 2;
                }
            }
            return Math.Round(y, 3);
        }
    }
}
