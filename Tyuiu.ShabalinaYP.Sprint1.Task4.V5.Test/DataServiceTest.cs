using Tyuiu.ShabalinaYP.Sprint1.Task4.V5.Lib;
namespace Tyuiu.ShabalinaYP.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double z = 0.333;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}