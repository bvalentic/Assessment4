using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndVirtualMethods
{
    class Shape
    {
        public float Side { get; set; }

        public Shape(float side)
        {
            Side = side;
        }

        public Shape()
        {
            Side = 0;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Hi, I am a shape");
        }
    }
}
