using Tyuiu.ShabalinaYP.Sprint1.Task0.V15.Lib;
namespace Tyuiu.ShabalinaYP.Sprint1.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(24, res);
        }
    }
}