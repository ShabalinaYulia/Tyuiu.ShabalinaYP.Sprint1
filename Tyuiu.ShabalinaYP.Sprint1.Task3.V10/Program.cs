using System.Security.Cryptography.X509Certificates;
using Tyuiu.ShabalinaYP.Sprint1.Task3.V10.Lib;
namespace Tyuiu.ShabalinaYP.Sprint1.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSevice ds = new DataSevice();
            //Console.WriteLine(Math.Floor(23.6));
            //double x;
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(x + " руб. " + "- " + "это " + Math.Floor(x) + "руб. " + Math.Round((x - Math.Floor(x))*100) + " коп.");
            //(x + " руб. " + "- " + "это " + Math.Floor(x) + "руб. " + Math.Round((x - Math.Floor(x)) * 100) + " коп.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x + " руб.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.NumberToMoney(x));
            Console.ReadLine();
        }
    }
}
