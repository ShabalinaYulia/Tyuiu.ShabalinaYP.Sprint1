using Tyuiu.ShabalinaYP.Sprint1.Task5.V5.Lib;
namespace Tyuiu.ShabalinaYP.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 35.675;
            var res = ds.Calculate(x);
            double answer = 6;
            Assert.AreEqual(answer, res);
        
        }
    }
}