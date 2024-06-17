using System;
using Object_Oriented_Programming_Demonstration.Inheritance_and_Method_Overriding;
using Object_Oriented_Programming_Demonstration.Abstract_Classes_and_Methods;
using Object_Oriented_Programming_Demonstration.Interfaces;

namespace Object_Oriented_Programming_Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance and Method Overriding
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();


            Console.WriteLine();

            // Abstract Classes and Methods
            Shape circle = new Circle(7);
            Shape rectangle = new Rectangle(8, 9);
            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");


            Console.WriteLine();

            // Interfaces
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();


            Console.WriteLine();
        }
    }
}

