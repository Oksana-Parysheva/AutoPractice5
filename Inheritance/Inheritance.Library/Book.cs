namespace Inheritance.Library
{
    public class Book
    {
        public Book(string name, string author)
        {
            Name = name;
            Author = new Author(author);
        }

        public string Name { get; }

        public Author Author { get; }

        public string GetInfo()
        {
            return $"name='{Name}', author='{Author.Fio}'";
        }
    }
}
