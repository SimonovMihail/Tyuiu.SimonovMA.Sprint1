﻿using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SimonovMA.Sprint1.Task2.V30.Lib
{
    public class DataService : ISprint1Task2V30
    {
        public double ConvertKmToMetre(double value)
        {
            double meters = value * 1000;
            return Math.Round(meters, 3);
        }
    }
}
