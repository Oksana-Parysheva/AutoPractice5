using System;

namespace Inheritance
{
    public class Siamese : Cat
    {
        public Siamese(string name)
            : base(name)
        {
            Console.WriteLine("Class siamese instantiated");
        }
    }
}
