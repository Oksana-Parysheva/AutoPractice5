using System;

namespace Inheritance
{
    public abstract class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("Class animal instantiated");
        }

        public abstract void MakeVoice();
    }
}
