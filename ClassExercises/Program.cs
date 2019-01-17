using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I added this in order to use debug.write
using System.Diagnostics;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new dog:
            Dog sam = new Dog();

            // Define the dog:
            sam.Breed = "Collie";
            sam.EyeColor = "brown";
            sam.Speed = 20;

            sam.NumberOfArms = 0;
            sam.NumberOfLegs = 4;
            sam.Type = "dog";

            // This writes to the Output window below:
            Debug.Write(sam.Breed);

            // Display his attributes:
            Console.WriteLine("Sam is a " + sam.Type + ".");
            Console.WriteLine("Sam's breed is " + sam.Breed + ".");
            Console.WriteLine("Sam has " + sam.EyeColor + " eyes.");
            Console.WriteLine("Sam has " + sam.NumberOfArms + " arms and " + sam.NumberOfLegs + " legs.");
            Console.WriteLine("Sam's speed is " + sam.Speed + " mph.");
            sam.Bark();
            sam.Eat(sam.Type);
            Console.ReadLine();
        }
    }
}
