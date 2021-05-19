using System;
using System.Collections.Generic;
using System.Linq;

namespace CircleTriangle
{
    public class Zadanie1
    {
        public static void count()
        {
            List<double> values = new List<double>();
            List<double> valuestrue = new List<double>();
            int valueamount = 0;
            string answer = "";
            Console.WriteLine("Введите значение для вычисления: ");
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    if (answer == "нет")
                        break;
                    values.Add(Math.Abs(Convert.ToDouble(Console.ReadLine())));
                    Console.WriteLine("Добавить ещё значения? (Да/Нет)");
                    switch (answer = Console.ReadLine())
                    {
                        case "да":
                            Console.WriteLine("Введите значение:");
                            continue;
                        case "нет":
                            break;
                        default:
                            Console.WriteLine("Введён некорректный ответ. Принимается как ответ 'да'");
                            break;

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Значение введено неверно!");
                }
            }
            int j = 0;
            foreach (var item in values)
            {
                if (values.ElementAt(j) != 0)
                {
                    valuestrue.Add(values.ElementAt(j));
                    Console.WriteLine(valuestrue.ElementAt(valueamount));
                    valueamount++;
                }
                j++;
            }
            switch (valueamount)
            {
                case 0:
                    Console.WriteLine("Значения отсутствуют.");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine("Получено одно значение. Вычисляем площадь круга по радиусу S = PI * (R*R)");
                    Circle(valuestrue.ElementAt(0));
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Получено два значения, такой фигуры не существует");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Получено три значения. Вычисляем площадь треугольника и проверяем, является ли он прямоугольным");
                    triangle(valuestrue.ElementAt(0), valuestrue.ElementAt(1), valuestrue.ElementAt(2));
                    break;
                default:
                    Console.WriteLine("Превышено допустимое количество значений для вычисления.");
                    Console.ReadLine();
                    break;

            }
        }
        public static void triangle(double side1, double side2, double side3)
        {
            if ((side1 * side1 + side2 * side2 == side3 * side3) || (side1 * side1 + side3 * side3 == side2 * side2) || (side3 * side3 + side2 * side2 == side1 * side1))
            {
                Console.WriteLine("Треугольник является прямоугольным. Вычисляем площадь: (" + side1 + " + " + side2 + " + " + side3 + ") / 2 = " + (side1 + side2 + side3) / 2);
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным. Вычисляем площадь: (" + side1 + " + " + side2 + " + "  + side3 +") / 2 = " + (side1 + side2 + side3) / 2);

            }
            Console.ReadLine();


        }
        public static void Circle(double radius)
        {
            Console.WriteLine("Площадь круга равна: " + Math.PI * Math.Pow(radius, 2));
            Console.ReadLine();
        }
    }
}
 
