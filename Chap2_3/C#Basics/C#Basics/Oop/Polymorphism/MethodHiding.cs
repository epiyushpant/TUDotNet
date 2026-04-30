namespace C_Basics.Oop.Polymorphism
{
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }
    public class Child : Parent
    {
        //Method Overriding
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
        //Method Hiding/Shadowing
        public new void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }
    }

    public class MethodHiding
    {
        public static void GetMethodHidingDemo()
        {
            Parent parent = new Parent();
            Child child = new Child();
            Parent parentRefChild = new Child();

            // Calling methods on Parent class object
            parent.Show();    // Outputs: Parent Class Show Method
            parent.Display(); // Outputs: Parent Class Display Method

            // Calling methods on Child class object
            child.Show();    // Outputs: Child Class Show Method
            child.Display(); // Outputs: Child Class Display Method

            // Calling methods on Parent reference pointing to Child object
            parentRefChild.Show();    // Outputs: Child Class Show Method (Overridden method)
            parentRefChild.Display(); // Outputs: Parent Class Display Method (Hidden method)


            // Explanation: Method hiding occurs when a method in a derived class has the same name as a method in the base class,
            // but is not marked with the 'override' keyword.
            // In this example, the 'Display' method in the Child class hides the 'Display' method in the Parent class.


            parentRefChild.Display(); // Outputs: Parent Class Display Method (Hidden method) , 
            //because the method is hidden, not overridden. The type of the reference (Parent) determines which method is called for hidden methods,
            //while the type of the object (Child) determines which method is called for overridden methods.

        }
    }
}

