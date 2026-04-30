using System;

namespace C_Basics.Oop.Inheritance.Types.Multiple
{
    // Two small interfaces show how a class can implement multiple behaviors
    public interface IAnimal
    {
        void Eat();
    }

    public interface IPet
    {
        void Play();
    }

    // Dog is both an animal and a pet
    public class Dog : IAnimal, IPet
    {
        public void Eat() => Console.WriteLine("Dog: Eating food.");
        public void Play() => Console.WriteLine("Dog: Playing with a ball.");
    }

    // Cat is also a pet but we show different behavior
    public class Cat : IPet
    {
        public void Play() => Console.WriteLine("Cat: Chasing a laser pointer.");
    }

    // Simple demo that students can read quickly
    public class TestMultipleInheritance
    {
        public static void GetCallInheritance()
        {
            Console.WriteLine("-- Concrete objects --");
            var dog = new Dog();
            dog.Eat();
            dog.Play();

            var cat = new Cat();
            cat.Play();

            Console.WriteLine();
            Console.WriteLine("-- Using interfaces (polymorphism) --");
            IAnimal animal = new Dog(); // treat Dog as an IAnimal
            animal.Eat();

            IPet pet = new Dog(); // treat Dog as an IPet
            pet.Play();

            IPet anotherPet = new Cat(); // Cat only implements IPet
            anotherPet.Play();

            Console.WriteLine();
            Console.WriteLine("-- Array of IPet (different types) --");
            IPet[] pets = { new Dog(), new Cat() };
            foreach (var p in pets)
            {
                p.Play();
            }
        }
    }
}
