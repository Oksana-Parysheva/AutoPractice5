using System;

namespace Inheritance
{
    public class Persian : Cat
    {
        public Persian(string name)
            : base(name)
        {
            Console.WriteLine("Class persian instantiated");
        }
    }
}
