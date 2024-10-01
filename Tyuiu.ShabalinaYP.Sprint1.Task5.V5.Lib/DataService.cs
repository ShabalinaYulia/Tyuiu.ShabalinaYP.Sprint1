using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShabalinaYP.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double k;
            k = Math.Floor(x);
            double j;
            j = (x - k) * 10;
            return (int)Math.Floor(j);
        }
    }

}
