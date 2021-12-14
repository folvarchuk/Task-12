using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    /*1.   Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
            - метод, определяющий длину окружности по заданному радиусу;
            - метод, определяющий площадь круга по заданному радиусу;
            - метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.*/
    class Program
    {
        static void Main(string[] args)
        {
            Circle.LengthCalc();
            Circle.SquareCalc();
            Circle.CircleSpace();
            Console.ReadKey();
        }
           
           
    }
    public static class Circle
    {
        public static int radius = 5;
        public static int x0 = 0;
        public static int y0 = 0;
        public static void LengthCalc()
        {
            double lengthOfCircuit = 2 * Math.PI * radius;
            Console.WriteLine("Длина окружности равна {0:f2}", lengthOfCircuit);
        }
        public static void SquareCalc()
        {
            double squareOfCircle = Math.PI * radius * radius;
            Console.WriteLine("Площадь окружности равна {0:f2}", squareOfCircle);
        }
        public static void CircleSpace()
        {
            Console.WriteLine("Введите координату х:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату у:");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((radius >= Math.Abs((x - x0))) && (radius >= Math.Abs((y - y0))))
            {
                Console.WriteLine("Точка с координатами (х,у) принадлежит заданной окружности");
            }
            else
            {
                Console.WriteLine("Точка с координатами (х,у) находится вне заданной окружности");
            }
        }
        
    }
}
