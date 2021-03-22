using System;

namespace Inheritance
{
    public class Labrador : Dog
    {
        public Labrador(string name)
            : base(name)
        {
            Console.WriteLine("Class Labrador instantiated");
        }

        public override void Bark()
        {
            Console.WriteLine("Labrador barks on you!");
        }
    }
}
