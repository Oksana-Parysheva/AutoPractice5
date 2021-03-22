using System;

namespace Inheritance
{
    public class Dog : Animal
    {
        public Dog(string name)
            : base(name)
        {
            Console.WriteLine("Class dog instantiated");
        }

        public override void MakeVoice()
        {
            Console.WriteLine($"{Name} says bark");
        }

    public virtual void Bark()
        {
            Console.WriteLine("Dog barks!");
        }
    }
}
