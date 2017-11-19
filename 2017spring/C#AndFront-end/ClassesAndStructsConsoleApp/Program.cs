using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    private int doors;
    private double engineLiters;

    public Car() { }  // 0 argument constructor

    public Car(int d, double e)  // multi argument constructor
    {
        doors = d;
        engineLiters = e;
    }

    public int Doors
    {
        get { return doors; }
        set { doors = value; }
    }

    public double EngineLiters
    {
        get { return engineLiters; }
        set { engineLiters = value; }
    }
}

// inheritance can also be called generalization

class SportsCar : Car
{
    

}

struct Auto
{
    public int doors;
    public double engineCI;

}

namespace ClassesAndStructsConsoleApp
{
    public struct FullName
    {
        public string firstName;
        public string lastName;
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            // the class
            // keep the member data private
            // therefore you need to use accessors or mutators to set/get data
            // or, create properties to set/get data
            Car ford = new Car();
            ford.Doors = 4;
            Console.WriteLine(ford.Doors);

            SportsCar dodge = new SportsCar();
            dodge.Doors = 2;
            Console.WriteLine(dodge.Doors);

            SportsCar honda = new SportsCar();


            // the struct
            // keep the member data public, generally
            // if the members are public, then you can just directly access their contents.

            Auto chevy;
            chevy.doors = 4;
            chevy.engineCI = 350.0;
            Console.WriteLine(chevy.doors);

            FullName myName;
            myName.firstName = "Daniel";
            myName.lastName = "Grigoletti";
        }
    }
}
