namespace C_Basics.Oop.Polymorphism
{
    public class Animal
    {
        // Virtual method in the base class
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        //Overriding the virtual method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        // Overriding the virtual method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    
    }
    
    public class MethodOverridingDemo
    {
        public static void GetOverriding() {

            Animal animal = new Animal();
            animal.MakeSound(); // Outputs "Animal makes a sound"

            //parent ko obj le parent kai call garyo 


            Animal myDog = new Dog(); // Upcasting
            myDog.MakeSound(); // Outputs "Dog barks"

            Animal myCat = new Cat(); // Upcasting
            myCat.MakeSound(); // Outputs "Cat meows"

            
            //parent ko obj le jun child lai point garyo tei call garcha 



            // Calling the overridden methods

            Dog dog = new Dog();
            dog.MakeSound();

            //child ko object le child ko call garyo 
            // child ma chaina vane parent bata lyaucha

            //BCRV - Base Class Reference Variable pointing to Derived Class Object will call the 
           // Derived Class overridden method.
        }
    }
}
