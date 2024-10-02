using Tyuiu.ShabalinaYP.Sprint1.Task7.V27.Lib;
namespace Tyuiu.ShabalinaYP.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            double x = 2, y = 4;
            var res = ds.Calculate(x, y);
            double wait = -3.597;
            Assert.AreEqual(wait, res);
        }
    }
}