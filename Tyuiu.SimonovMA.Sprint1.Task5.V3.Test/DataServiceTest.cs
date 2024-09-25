using System;
using Tyuiu.SimonovMA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.SimonovMA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void UltraMegaAlphaGigaSuperTESTING()
        {
            DataService ds = new DataService();
            int k = 36578683;
            int res = ds.Calculate(k);
            Assert.AreEqual(res, 6);
        }
    }
}