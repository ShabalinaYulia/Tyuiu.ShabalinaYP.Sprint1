using Tyuiu.ShabalinaYP.Sprint1.Task2.V12.Lib;

namespace Tyuiu.ShabalinaYP.Sprint1.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
        //Console.Title = "Спринт #0 | Выполнил: Шабалина Ю. П. | ПКТб-24-1";
        //Console.WriteLine("***************************************************************************");
        //Console.WriteLine("* Спринт #1                                                               *");
        //Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        //Console.WriteLine("* Задание #0                                                              *");
        //Console.WriteLine("* Вариант #15                                                             *");
        //Console.WriteLine("* Выполнил: Шабалина Юлия Павловна | ПКТб-24-1                        *");
        //Console.WriteLine("***************************************************************************");
        //Console.WriteLine("* УСЛОВИЕ:                                                                *");
        //Console.WriteLine("* Написать программу, которая вычисляет 20 - (2 * 2 - 8)                  *");
        //Console.WriteLine("* и печатает результат на экране                                          *");
        //Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            int y;
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());
            int z;
            Console.WriteLine("Введите значение Z:");
            z = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("* 20 - (2 * 2 - 8)                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CalculateParallelepipedVolume(x, y, z));
            Console.ReadLine();
        }
    }
}
