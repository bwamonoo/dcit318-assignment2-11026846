using System;

namespace InheritanceDemo
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Inheritance & Method Overriding ---");

            Animal generic = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            generic.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}