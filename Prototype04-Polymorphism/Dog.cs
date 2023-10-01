﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype04_Polymorphism
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
            
        }
    }
}
