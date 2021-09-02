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
                    case ("2"):
                        InsertBook();
                        break;
                    case ("3"):
                        //UpdateBook();
                        break;
                    case ("4"):
                        //DeleteBook();
                        break;
                    case ("5"):
                        //ViewBook();
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

        public static void InsertBook()
        {
            Console.WriteLine(Environment.NewLine + "Insert new book");

            foreach (var i in Enum.GetValues(typeof(Category)))
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Category), i)}");

            Console.WriteLine(Environment.NewLine + "Please select the book category: ");
            int category = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the book title: ");
            string tittle = Console.ReadLine();

            Console.WriteLine("Enter the book description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter the book year: ");
            int year = int.Parse(Console.ReadLine());

            Book book = new Book(bookRepository.NextId(), (Category)category, tittle, description, year);

            bookRepository.Insert(book);
        }
    }
}
