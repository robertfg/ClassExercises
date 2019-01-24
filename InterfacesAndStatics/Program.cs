using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStatics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate object based on class:
            Plant plant = new Plant();

            // Instantiate object based on interface:
            IPlant daisy = new Plant();

            Rock.Size = 10.0;
            Rock.Decay();

            // Can't instantiate a static class:
            //Rock gem = new Rock();

            Console.WriteLine(Rock.Size);
            Console.ReadLine();
        }
    }
}
