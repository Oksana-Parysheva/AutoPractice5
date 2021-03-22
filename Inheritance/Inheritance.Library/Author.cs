namespace Inheritance.Library
{
    public class Author : Person
    {
        public Author(string fio) : base(fio)
        {
        }

        public string Bio { get; set; }
    }
}
