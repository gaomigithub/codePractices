using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Polymorphism
{
// In-Class Assignment #1 - Due 02/29/16 at 6PM
// Complete the following polymorphic program
// Add the necessary method overrides into the Dog and Bird classes
// Add the constructors to the Dog and Bird classes (default and 2-argument)
// Add the code necessary to 
// 1.  Create objects of the Dog and Bird classes
// 2.  Place the objects into the array of Animal.
// 3.  Run the abstract method that you overrode

// An abstract base class:

abstract class Animal  // an abstract class cannot be instantiated
{
    protected string message;
    protected string animalName;

    abstract public void Speak();  // the abstract method must be implemented in every class that inherits from Animal
}

class Cat : Animal
{
    public Cat() { }
    public Cat(string n, string m)
    {
        animalName = n;
        message = m;
    }

    public override void Speak()
    {
        Console.WriteLine("The Cat named {0} says {1}", animalName, message);
        Console.WriteLine("{0} is on the prowl!\n", animalName);
    }
}

class Dog : Animal
{
    public Dog() { }
    public Dog(string n, string m)
    {
        animalName = n;
        message = m;
    }
    public override void Speak()
    {
        Console.WriteLine("The Dog named {0} says {1}", animalName, message);
        Console.WriteLine("{0} is sleeping in it's house!\n", animalName);
    }
}

class Bird: Animal
{
    public Bird() { }
    public Bird(string n, string m)
    {
        animalName = n;
        message = m;
    }

    public override void Speak()
    {
        Console.WriteLine("The Bird named {0} says {1}", animalName, message);
        Console.WriteLine("{0} is flying above the trees!\n", animalName);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Animal [] Pets = new Animal[4];

            Cat garfield = new Cat("Garfield", "meow");
            Dog goofy = new Dog("Goofy", "woof");
            Bird bigBird = new Bird("Big Bird", "chirp");

            // Create a Dog object
            // Create a Cat object
            Pets[0] = garfield;
            Pets[1] = goofy;
            Pets[2] = bigBird;
            Pets[3] = new Dog("Snoopy", "whine");
            
            // add dog to Pets[] array element 1
            // add bird to Pets[] array element 2
            // The line below has garfield speak
            //garfield.Speak();
            //The line below just has the cat speak while in the array:
            //Pets[0].Speak();

            // use a foreach loop to show what each pet says
            for (int i = 0; i < Pets.Length; ++i )
            {
                Pets[i].Speak();
            }

                /*foreach (Animal pet in Pets)
                {
                    pet.Speak();
                }
                 */
                 
        }
    }
}
