using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleTriangle;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1.count(); //Запуск библиотеки с вводом данных

            double side1 = 2, side2 = 3, side3 = 5;
            Zadanie1.triangle(side1, side2, side3); //Вызов метода для вычисления площади необходимой фигуры (треугольник)

            double rad = 5;

            Zadanie1.Circle(rad); //Вызов метода для вычисления площади необходимой фигуры (круг)
        }
    }
}
 
