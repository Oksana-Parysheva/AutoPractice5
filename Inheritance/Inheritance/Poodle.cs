using System;

namespace Inheritance
{
    public class Poodle : Dog
    {
        public Poodle(string name)
            : base(name)
        {
            Console.WriteLine("Class Poodle instantiated");
        }
    }
}
