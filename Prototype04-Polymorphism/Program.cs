using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype04_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Dog();
            Animal animal3 = new Cat();

            animal1.MakeSound(); // Output: The animal makes a sound.
            animal2.MakeSound(); // Output: The dog barks.
            animal3.MakeSound(); // Output: The cat meows.
        }
    }
}
