using System;
using Tyuiu.SimonovMA.Sprint1.Task7.V21.Lib;

namespace Tyuiu.SimonovMA.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MMMM_CRUTOI_TESTIK()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 2;
            double z = ds.Calculate(x, y);
            Assert.AreEqual(z, -245.268);
        }
    }
}