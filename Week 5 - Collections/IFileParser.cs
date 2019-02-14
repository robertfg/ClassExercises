using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5_Collections
{
    interface IFileParser
    {

        // Methods
        string[] Read(string path);

        void Write(string path, string[] cities, string newCity);
    }
}
