using System;
using System.Text;

namespace Work5
{
    class User
    {
        public static string log;
        public static string name;
        public static string surname;
        public static int age;
        private static string data;
        public User(string data)
        {
            Console.WriteLine("Введите логин: ");
            log = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            User.data = data;
        }
        public static void Show()
        {
            Console.WriteLine("Логин: " + log);
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Фамилия: " + surname);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Дата: " + data);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите дату: ");
            string data = Console.ReadLine();
            User new_person = new User(data);
            User.Show();
            Console.ReadLine();
        }
    }
}
