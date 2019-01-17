using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Animal
    {
        /* ***** PROPERTIES ***** */
        public int NumberOfLegs { get; set; }
        public int NumberOfArms { get; set; }
        public string Type { get; set; }

        /* ***** METHODS ***** */
        public void Eat(string animalType)
        {
            Console.WriteLine("The " + animalType + " is eating.");
        }
    }
}
