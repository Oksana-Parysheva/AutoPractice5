using System;

namespace Inheritance
{
    public class Cat : Animal
    {
        public Cat(string name)
            : base(name)
        {
            Console.WriteLine("Class cat instantiated");
        }

        public override void MakeVoice()
        {
            Console.WriteLine($"{Name} says meow");
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} says meow");
        }
    }
}
