using System;

namespace C_Basics.Oop.Inheritance.Types
{
    public class Animal
    {
        public void Eat() { Console.WriteLine("Animal: eating..."); }
    }

    public class Mammal : Animal
    {
        public void Breathe() { Console.WriteLine("Mammal: breathing..."); }
    }

    public class Dog : Mammal
    {
        public void Bark() { Console.WriteLine("Dog: barking..."); }
    }

    // Small demo for multilevel inheritance
    public static class MultilevelDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("-- Multilevel Inheritance Demo --");

            var dog = new Dog();
            // Dog has access to members from Dog, Mammal and Animal
            dog.Eat();      // from Animal
            dog.Breathe();  // from Mammal
            dog.Bark();     // from Dog

        }
    }
}
