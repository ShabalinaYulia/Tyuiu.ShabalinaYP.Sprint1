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
            double x = 1, y = -1;
            var res = ds.Calculate(x, y);
            double wait = 7.145;
            Assert.AreEqual(wait, res);
        }
    }
}