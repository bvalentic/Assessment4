using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndVirtualMethods
{
    class Square : Shape
    {
        public Square(float side) : base(side)
        {//inherits Side and getter/setter from Shape

        }

        public Square() : base()
        {//this isn't necessary since the default Shape constructor does the same thing, 
         //but just to be on the safe side as far as build specs go I'm including it here too
            Side = 0;
        }

        public override void Draw()
        {
            Console.WriteLine("Hi, I am a square!");
        }

        public float GetArea()
        {//area of square = length^2
            return this.Side * this.Side;
        }
    }
}
