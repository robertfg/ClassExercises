using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStatics
{
    static class Rock
    {
        public static double Size { get; set; }

        public static void Decay()
        {
            if ( Size > 0 )
            {
                Size -= 0.001;
            }
        }
    }
}
