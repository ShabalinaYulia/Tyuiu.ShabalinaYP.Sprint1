﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShabalinaYP.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        { 
            double z = (Math.Pow(Math.Cos(x), 2) + Math.Pow(Math.Sin(y), 2)) / (Math.Sin(y) + 1) - ((x * y - 12) / (15 + Math.Cos(x)));
            return Math.Round(z, 3);
        }
    }
}
