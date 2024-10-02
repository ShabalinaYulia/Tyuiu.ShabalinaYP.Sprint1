using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShabalinaYP.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double f = (Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(y, 2))) / (Math.Sin(y) + 1);
            double s = (x * y - 12) / (15 + Math.Cos(x));
            double z = f - s;
            return Math.Round(z, 3);
        }
    }
}