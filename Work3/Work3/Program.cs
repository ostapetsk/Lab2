using System;
using System.Text;

namespace Work3
{
    class Book
    {
        public static void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
        public static class Title
        {
            public static string title;
            public static void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Название книги: " + title);
            }
        }
        public static class Author
        {
            public static string author;
            public static void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Автор: " + author);
            }
        }
        public static class Content
        {
            public static string content;
            public static void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Содержание: " + content);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите название книги: ");
            Book.Title.title = Console.ReadLine();
            Console.WriteLine("Введите автора книги: ");
            Book.Author.author = Console.ReadLine();
            Console.WriteLine("Введите содержание книги: ");
            Book.Content.content = Console.ReadLine();
            Book.Show();
            Console.ReadLine();
        }
    }
}
