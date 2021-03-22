using System;

namespace Inheritance.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader1 = new Reader("Петров И.И.", 1, new DateTime(1999, 10, 21), "+3809711111");
            Reader reader2 = new Reader("Сидоров И.В.", 2, new DateTime(1997, 11, 11), "+38097222222");
            Reader reader3 = new Reader("Иванов А.В.", 3, new DateTime(2005, 04, 05), "+38097333333");
            Reader[] readers = { reader1, reader2, reader3 };

            Book book1 = new Book("Гарри Поттер и кубок огня", "Дж.Роулинг");
            Book book2 = new Book("Пикник на обочине", "Стругацкие");
            Book book3 = new Book("Мое здоровье", "Доктор");
            Book[] books = { book1, book2, book3 };

            PrintReaders(readers);
            PrintBooks(books);

            reader1.TakeBook(5);
            reader2.TakeBook(book1, book2, book3);
            reader3.TakeBook("Java программирование, Шилдт");

            Console.ReadKey();
        }

        private static void PrintBooks(Book[] books)
        {
            Console.WriteLine("Список книг:");
            foreach(Book book in books)
            {
                Console.WriteLine(book.GetInfo());
            }
            Console.WriteLine();
        }

        private static void PrintReaders(Reader[] readers)
        {
            Console.WriteLine("Список читателей:");
            foreach (Reader reader in readers)
            {
                Console.WriteLine(reader.GetInfo());
            }
            Console.WriteLine();
        }
    }
}
