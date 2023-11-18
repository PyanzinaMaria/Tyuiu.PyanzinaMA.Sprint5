using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double y = (1 + Math.Pow(x, 3)) / Math.Pow(x, 2);

            double res = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
