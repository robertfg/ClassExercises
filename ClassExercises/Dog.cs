using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Dog:Animal
    {
        /* ***** PROPERTIES ***** */
        public string Breed { get; set; }
        public string EyeColor { get; set; }
        public int Speed { get; set; }
        
        /* ***** METHODS ***** */
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }

    }
}
