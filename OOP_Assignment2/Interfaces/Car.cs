﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Demonstration.Interfaces
{
    internal class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
