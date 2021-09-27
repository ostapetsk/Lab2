using System;
using System.Text;

namespace Work8
{
    class Invoice
    {
        int account;
        string customer;
        string provider;
        private string article;
        private static int quantity;
        public static double cost;
        public static double price;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public Invoice(string tovar, int quantity, double price)
        {
            Invoice.quantity = quantity;
            Invoice.price = price;
            Invoice.WithHDC();
            Invoice.WithoutHDC();
        }
        public static void WithHDC()
        {
            cost = quantity * price * 0.8;
            Console.WriteLine("Сумма платежа с НДС товара: " + cost);
        }
        public static void WithoutHDC()
        {
            cost = quantity * price;
            Console.WriteLine("Сумма платежа без НДС товара: " + cost);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Какой товар будете заказывать? ");
            string tovar = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите кол-во заказываемого товара: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цена товара: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Invoice Person = new Invoice(344212, "Олег", "Кирилл");
            Invoice Item = new Invoice(tovar, quantity, price);
        }
    }
}