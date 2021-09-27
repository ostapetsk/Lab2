using System;
using System.Text;

namespace Work7
{
    class Employee
    {
        public static string Name;
        public static string Surname;
        public static double age;
        private static string Input;
        public static double Oklad;
        public static double Nalog;
        public Employee()
        {
            Console.WriteLine("Введите ваше имя: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите вашу фамилию: ");
            Surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите стаж работы: ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите должность: ");
            Console.WriteLine("Введите '1' - Менеджер");
            Console.WriteLine("Введите '2' - Зам. Директора");
            Console.WriteLine("Введите '3' - Директор");
            Input = Convert.ToString(Console.ReadLine());
            Employee.Calculator();
        }
        public static void Calculator()
        {
            if (Input == "1")
            {
                Console.WriteLine("Имя: " + Name);
                Console.WriteLine("Фаамилия: " + Surname);
                Console.WriteLine("Должность: Менеджер");
                Nalog = 20000 * 0.2 / age;
                Oklad = 20000 - Nalog;
                Console.WriteLine("Налог: " + Nalog);
                Console.WriteLine("Оклад: " + Oklad);
            }
            else if (Input == "2")
            {
                Console.WriteLine("Имя: " + Name);
                Console.WriteLine("Фамилия: " + Surname);
                Console.WriteLine("Должность: Зам. Директора");
                Nalog = 45000 * 0.2 / age;
                Oklad = 45000 - Nalog;
                Console.WriteLine("Налог: " + Nalog);
                Console.WriteLine("Оклад: " + Oklad);
            }
            else if (Input == "3")
            {
                Console.WriteLine("Имя: " + Name);
                Console.WriteLine("Фамилия: " + Surname);
                Console.WriteLine("Должность: Директор");
                Nalog = 80000 * 0.2 / age;
                Oklad = 80000 - Nalog;
                Console.WriteLine("Налог: " + Nalog);
                Console.WriteLine("Оклад: " + Oklad);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Employee new_person = new Employee();
            Console.ReadLine();
        }
    }
}