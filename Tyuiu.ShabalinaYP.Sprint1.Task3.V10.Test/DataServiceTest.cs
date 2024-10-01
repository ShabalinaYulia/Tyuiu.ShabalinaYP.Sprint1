using Tyuiu.ShabalinaYP.Sprint1.Task3.V10.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.ShabalinaYP.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataSevice ds = new DataSevice();
            double x = 23.6;
            var res = ds.NumberToMoney(x);
            double a = 60;
            Assert.AreEqual(x, res);
        }
    }
}