using Tyuiu.ShabalinaYP.Sprint1.Task1.V25.Lib;
namespace Tyuiu.ShabalinaYP.Sprint1.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest

    {

        [TestMethod]

        public void ValidExpression()

        {

            DataService ds = new DataService();

            double x = 2.0;

            double y = 2.0;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(1,33, res);

        }

    }

}