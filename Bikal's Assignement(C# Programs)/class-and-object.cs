using System;

class Student
{
    public string name;
    public int age;
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        
        s1.name = "Ram";
        s1.age = 22;

        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
    }
}