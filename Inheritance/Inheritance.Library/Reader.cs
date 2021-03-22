using System;

namespace Inheritance.Library
{
    public class Reader : Person
    {
        public Reader(string fio, int number, DateTime dateOfBirth, string phone) : base(fio)
        {
            Number = number;
            DateOfBirth = dateOfBirth;
            Phone = phone;
        }

        public int Number { get; }

        public DateTime DateOfBirth { get; }

        public string Phone { get; }

        public void TakeBook(int number)
        {
            Console.WriteLine($"{Fio} взял {number} книги.");
        }

        public void TakeBook(params string[] books)
        {
            Console.WriteLine($"{Fio} взял следующие книги:");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void TakeBook(params Book[] books)
        {
            Console.WriteLine($"{Fio} взял следующие книги:");
            foreach(Book book in books)
            {
                Console.WriteLine($"{book.Name}, автор - {book.Author.Fio}");
            }
        }

        internal string GetInfo()
        {
            return $"fio='{Fio}', number={Number}, dob='{DateOfBirth.ToString("dd.MM.yyyy")}', phone='{Phone}'";
        }
    }
}
