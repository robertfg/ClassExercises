using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Addition for file reading/writing
using System.IO;

namespace Wk4_FileIO
{
    class Book
    {
        // Properties
        public int numPages { get; set; }
        public double currentPage { get; set; }
        public string title { get; set; }

        // Methods
        public void OutputTofile()
        {
            using (StreamWriter streamWriter = new StreamWriter("Book.txt"))
            {
                streamWriter.WriteLine(title);
                streamWriter.WriteLine(numPages);
                streamWriter.WriteLine(currentPage);
            }
        }
    }
}
