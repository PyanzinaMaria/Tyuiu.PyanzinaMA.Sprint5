using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PyanzinaMA.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int t = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double n = Convert.ToDouble(line);
                    if ((n >= -10 && n <= 10) && (n % 1 ==0))
                    {
                        t++;
                        res += n;
                    }
                }                
            }
            return Math.Round((res / t), 3);
        }
    }
}

