using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndVirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* SOLID principles in action:
             *  Single Responsibility - the methods used only do one simple task, which can be used in other methods as building blocks
             *  Open/Closed - the Square class is an extension of the base Shape class; 
             *      the class has extended behavior in GetArea but can still Draw
             *  Liskov Substitution - a Square can do anything a Shape can do, meaning it can substitute Shape in any part of the 
             *      (admittedly simple) code with no errors
             *  Interface Segregation - the original version of this program used the IShape interface, 
             *      which would have allowed the shape classes to call Draw, a void method. IShape (and by extension Shape) 
             *      doesn't need to know about the GetArea method, as it would require different variables depending on the
             *      shape itself (Square requires a side, a Circle would require a radius, etc.
             *  Dependency Inversion - the virtual methods and interfaces (Draw()) aren't dependent on anything besides actual implementation
             */

            //default Shape test
            Shape testShape = new Shape();
            testShape.Draw();

            //Square test
            Square testSquare = new Square(4.5F);//had to use 'F' to cast as a float (who knew?)
            testSquare.Draw();
            double testArea = testSquare.GetArea();
            Console.WriteLine($"My area is {testArea}.");

            //default Square test
            Square testDefaultSquare = new Square();
            testDefaultSquare.Draw();
            double testDefaultArea = testDefaultSquare.GetArea();
            Console.WriteLine($"My area is {testDefaultArea}.");

            Console.ReadKey();
        }
    }
}
