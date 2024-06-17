using System;

namespace Object_Oriented_Programming_Demonstration.Abstract_Classes_and_Methods
{
    internal class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

