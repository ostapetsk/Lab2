﻿using System;
using System.Text;

namespace Work6
{
    class Converter
    {
        private static double Input;
        private static string InputNumber;
        private static double Output;
        public Converter(double usd, double eur, double rub)
        {
            Console.WriteLine("З якої валюти й в яку конвертувати ? ");
            Console.WriteLine("Введіть '1', щоб конвертувати UAH в USD ");
            Console.WriteLine("Введіть '2', щоб конвертувати UAH в EUR ");
            Console.WriteLine("Введіть '3', щоб конвертувати UAH в RUB ");
            Console.WriteLine("Ввеліть '4', щоб конвертувати USD в UAH ");
            Console.WriteLine("Ввеліть '5', щоб конвертувати EUR в UAH ");
            Console.WriteLine("Ввеліть '6', щоб конвертувати RUB в UAH ");
            InputNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть кількість обраної валюти, що конвертується: ");
            Input = Convert.ToDouble(Console.ReadLine());
            if (InputNumber == "1")
            {
                Output = Input / usd;
                Console.WriteLine("USD: " + Output);
            }
            else if (InputNumber == "2")
            {
                Output = Input / eur;
                Console.WriteLine("EUR: " + Output);
            }
            else if (InputNumber == "3")
            {
                Output = Input / rub;
                Console.WriteLine("RUB: " + Output);
            }
            else if (InputNumber == "4")
            {
                Output = Input * usd;
                Console.WriteLine("UAH: " + Output);
            }
            else if (InputNumber == "5")
            {
                Output = Input * eur;
                Console.WriteLine("UAH: " + Output);
            }
            else if (InputNumber == "6")
            {
                Output = Input * rub;
                Console.WriteLine("UAH: " + Output);
            }
            else
            {
                throw new Exception("Некорректный ввод данных");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            double usd = 26.73;
            double eur = 31.32;
            double rub = 0.37;
            Converter process = new Converter(usd, eur, rub);
        }
    }
}
