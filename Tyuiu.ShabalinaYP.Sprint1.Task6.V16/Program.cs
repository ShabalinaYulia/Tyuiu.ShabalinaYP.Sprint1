using Tyuiu.ShabalinaYP.Sprint1.Task6.V16.Lib;
namespace Tyuiu.ShabalinaYP.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CheckSpecSymbols(str));
            Console.ReadKey();
        }
    }
}
