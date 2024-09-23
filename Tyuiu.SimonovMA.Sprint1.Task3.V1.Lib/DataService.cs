using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SimonovMA.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            return Math.Round(r * h, 3);
        }
    }
}
