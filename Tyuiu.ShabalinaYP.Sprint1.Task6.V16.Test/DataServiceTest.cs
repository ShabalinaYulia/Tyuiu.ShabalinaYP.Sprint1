using System.Globalization;
using Tyuiu.ShabalinaYP.Sprint1.Task6.V16.Lib;
namespace Tyuiu.ShabalinaYP.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "hello?";
            var res = ds.CheckSpecSymbols(x);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}