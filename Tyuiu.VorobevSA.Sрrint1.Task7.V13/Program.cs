using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sрrint1.Task7.V13.Lib;

namespace Tyuiu.VorobevSA.Sрrint1.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:                                    *");
            Console.WriteLine("* Задание #1.7                                                            *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая вычисляет математическое выражение по        *");
            Console.WriteLine("*исходным значениям данных, вводимых пользователем. Ответ округлите       *");
            Console.WriteLine("*до 3 знаков после запятой.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y=");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("   y^2+cos(x^2)+10" );
            Console.WriteLine("z=-----------------=" + service1.Calculate(x, y));
            Console.WriteLine("   x^2+sin(y^2)+10" );

            Console.ReadKey();
        }
    }
}
