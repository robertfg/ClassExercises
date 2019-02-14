using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wk5_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boilerplate to store the name of a file:
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(currentDir);
            var fileName = Path.Combine(dir.FullName, "data.txt");

            // Read the file:
            IFileParser ifp = new FileParser();
            string[] strArray = ifp.Read(fileName);

            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            // Add new city:
            ifp.Write(fileName, strArray, "Chicago");
            strArray = ifp.Read(fileName);

            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
