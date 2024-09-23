using System;
using Tyuiu.SimonovMA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.SimonovMA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double r = 1;
            double h = 2;

            double res = ds.CylinderVolume(r, h);
            Assert.AreEqual(6.283, res);
        }
    }
}