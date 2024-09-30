using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShabalinaYP.Sprint1.Task3.V10.Lib
{
    public class DataSevice : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            double r;
            r = Math.Floor(number);
            double k;
            k = Math.Round((number - Math.Floor(number)) * 100);
            return k;

        }
    }
}
