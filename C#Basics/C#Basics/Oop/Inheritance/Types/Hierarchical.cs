using System;

namespace C_Basics.Oop.Inheritance.Types.Hier
{
    // Very simple hierarchical inheritance example for students
    public class Animal
    {
        public virtual void Eat() => Console.WriteLine("Animal: eats food.");
    }

    public class Dog : Animal
    {
        public override void Eat() => Console.WriteLine("Dog: eats dog food.");
        public void Bark() => Console.WriteLine("Dog: barks.");
    }

    public class Cat : Animal
    {
        public override void Eat() => Console.WriteLine("Cat: eats cat food.");
        public void Meow() => Console.WriteLine("Cat: meows.");
    }

    // Small demo: easy to read and show inheritance + override
    public static class HierarchicalDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("-- Dog --");
            var dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine();
            Console.WriteLine("-- Cat --");
            var cat = new Cat();
            cat.Eat();
            cat.Meow();

            Console.WriteLine();
            Console.WriteLine("-- Base reference pointing to derived (polymorphism) --");
            Animal a = new Dog();
            a.Eat(); // calls Dog.Eat because of override
        }
    }
}
