using System;
using Tyuiu.SimonovMA.Sprint1.Task2.V30.Lib;

namespace Tyuiu.SimonovMA.Sprint1.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertKmToMetre(x);
            Assert.AreEqual(2000, res);
        }
    }
}