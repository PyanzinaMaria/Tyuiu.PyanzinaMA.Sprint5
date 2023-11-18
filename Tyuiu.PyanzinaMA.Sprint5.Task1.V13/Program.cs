using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PyanzinaMA.Sprint5.Task1.V13.Lib;

namespace Tyuiu.PyanzinaMA.Sprint5.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Пьянзина М.А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 13                                                              *");
            Console.WriteLine("* Выполниа: Пьянзина Мария Алексеевна | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, произвести табулирование f(x) на заданном диапазоне [-5;5]*");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на 0. При делении на ноль вернуть*");
            Console.WriteLine("* значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt и  *");
            Console.WriteLine("* вывести на консоль в таблицу. Значения округлить до двух знаков после   *");
            Console.WriteLine("* запятой.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл: {res}\nСоздан!");

            double result;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 1)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Round((((2 * x - 3) / (Math.Cos(x) + x)) + 5), 2);
                }
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
