using System;
using System.Text;

namespace Work2
{
    class Rectangle 
    {
        private static double side1, side2;
        private static double Area;
        private static double Perimeter;
        public Rectangle(double side1, double side2)
        {
            Rectangle.side1 = side1;
            Rectangle.side2 = side2;
        }
        public static double AreaCalculator()
        {
            Area = side1 * side2;
            return Area;
        }
        public static double PerimeterCalculator()
        {
            Perimeter = (side1 + side2) * 2;
            return Perimeter;
        }
        public static double area
        {
            get
            {
                return Area;
            }
        }
        public static double perimeter
        {
            get
            {
                return Perimeter;
            }
        }
        public static void Show()
        {
            Console.WriteLine("Периметр: " + Perimeter);
            Console.WriteLine("Площадь: " + Area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите первую сторону прямоугольника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямогульника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle figure = new Rectangle(side1, side2);
            Rectangle.AreaCalculator();
            Rectangle.PerimeterCalculator();
            Rectangle.Show();
            Console.ReadLine();
        }
    }
}
