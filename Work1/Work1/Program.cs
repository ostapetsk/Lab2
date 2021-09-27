using System;
using System.Text;

namespace Work1
{
    class Adress
    {
        private static int index;
        public static int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        private static string country;
        public static string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private static string city;
        public static string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private static string street;
        public static string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private static int house;
        public static int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        private static int apartment;
        public static int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
        public static void Show()
        {
            Console.WriteLine("Індекс: " + index);
            Console.WriteLine("Страна: " + country);
            Console.WriteLine("Город: " + city);
            Console.WriteLine("Улица: " + street);
            Console.WriteLine("Дом: " + house);
            Console.WriteLine("Номер апартамента: " + apartment);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите индекс: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Adress.Index = index;
            Console.WriteLine("Введите страну: ");
            string country = Console.ReadLine();
            Adress.Country = country;
            Console.WriteLine("Введите город: ");
            string city = Console.ReadLine();
            Adress.City = city;
            Console.WriteLine("Введите улицу: ");
            string street = Console.ReadLine();
            Adress.Street = street;
            Console.WriteLine("Введите дом: ");
            int house = Convert.ToInt32(Console.ReadLine());
            Adress.House = house;
            Console.WriteLine("Введите номер апартамента: ");
            int apartment = Convert.ToInt32(Console.ReadLine());
            Adress.Apartment = apartment;
            Adress.Show();
            Console.ReadLine();
        }
    }
}
