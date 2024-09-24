using System;
using Tyuiu.SimonovMA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.SimonovMA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SuperUltraMegaCoolTest()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(res, 0.0625);
        }
    }
}