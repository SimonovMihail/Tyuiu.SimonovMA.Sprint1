using System;
using Tyuiu.SimonovMA.Sprint1.Task6.V8.Lib;

namespace Tyuiu.SimonovMA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void BeegTest()
        {
            DataService ds = new DataService();
            string value = "привет мир";
            string res = ds.MoveLetterToEnd(value);
            Assert.AreEqual(res, "риветп ирп");
        }
    }
}