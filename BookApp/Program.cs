using System;

namespace BookApp
{
    class Program
    {
        static BookRepository bookRepository = new BookRepository();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case ("1"):
                        ListBooks();
                        break;
                    case ("C"):
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine("====================================");
            Console.WriteLine(".Net Library, book's for you future");
            Console.WriteLine("====================================");
            
            Console.WriteLine("Please select your choice:");
            Console.WriteLine("1 - List books");
            Console.WriteLine("2 - Insert new book");
            Console.WriteLine("3 - Atualize book");
            Console.WriteLine("4 - Delete book");
            Console.WriteLine("5 - View book");
            Console.WriteLine("C - Clean screen");
            Console.WriteLine("X - Exit");

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }

        public static void ListBooks()
        {
            Console.WriteLine("Book list");

            var listBooks = bookRepository.List();

            if (listBooks.Count == 0)
                Console.WriteLine("There are no registered books");
            
            else
            {
                foreach (var book in listBooks)
                    Console.WriteLine($"#ID {book.returnId()}: {book.returnTitle()}.");
            }

        }
    }
}
