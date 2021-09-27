using System;
using System.Text;

namespace Work4
{
    class Point
    {
        public int X { get; }
        public int Y { get; }
        public string Name { get; }
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
    class Figure
    {
        public static int count;
        public Point[] points { get; }
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }
        public double LengthSize(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
        public void PerimeterCalculator()
        {
            double Perimeter = 0;
            for (int i = 0; i < count; i++)
            {
                if (i == points.Length - 1)
                {
                    Perimeter += LengthSize(points[i], points[0]);
                }
                else
                {
                    Perimeter += LengthSize(points[i], points[i + 1]);
                }
            }
            Console.WriteLine("Периметр фигури: " + Perimeter);
        }
        public void WhatIsFigure()
        {
            Console.WriteLine("Введите кол-во углов: ");
            count = Convert.ToInt32(Console.ReadLine());
            if (count < 3 || count > 5)
            {
                throw new Exception("Ошибка при вводе");
            }
            if (count == 3)
            {
                Console.WriteLine("Фигура: треугольник");
            }
            else if (count == 4)
            {
                Console.WriteLine("Фигура: четырехугольник");
            }
            else if (count == 5)
            {
                Console.WriteLine("Фигура: пятиугольник");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Figure figure = new Figure(new Point(0, 6, "A"), new Point(0, 0, "B"), new Point(6, 0, "C"), new Point(6, 6, "D"), new Point(3, 9, "E"));
            figure.WhatIsFigure();
            figure.PerimeterCalculator();
            Console.ReadLine();
        }
    }
}
