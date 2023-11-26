using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double result = Math.Sin(Math.Pow(x, 3)) + 2 / x ;
            return Math.Round(result, 3);
        }
    }
}
