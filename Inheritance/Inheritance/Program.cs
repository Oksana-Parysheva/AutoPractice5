using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal("Animal");
            Animal persianCat = new Persian("Persian");
            Cat siameseCat = new Siamese("Siamese"); 
            Dog poodle = new Poodle("Poodle");
            Dog labrador = new Labrador("Labrador");

            siameseCat.MakeVoice();
            poodle.MakeVoice();

            labrador.Bark();
            poodle.Bark();
            siameseCat.MakeVoice();
            siameseCat.Meow();

            Console.ReadKey();
        }
    }
}
