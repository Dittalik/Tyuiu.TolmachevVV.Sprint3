using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint3.Task6.V26.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Задание #6                                                               *");
            Console.WriteLine("*Вариант #26                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("отрезок от 15 до 22                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(service1.GetSumTheDivisors(15, 22));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
