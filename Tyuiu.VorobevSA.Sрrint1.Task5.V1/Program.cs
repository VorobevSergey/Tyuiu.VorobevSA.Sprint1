using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sрrint1.Task5.V1.Lib;


namespace Tyuiu.VorobevSA.Sрrint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #1.5                                                            *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.Write("Введите первую координату Х=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите вторую координату X=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y=");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние от одной точки до другой="+ service1.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadKey();
        }
    }
}
