using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wk5_Collections
{
    class FileParser : IFileParser
    {
        public string[] Read(string path)
        {
            int arraySize;
            string[] array;

            using (StreamReader streamReader = new StreamReader(path))
            {
                if (int.TryParse(streamReader.ReadLine(), out arraySize))
                {
                    array = new string[arraySize];

                    for (var i = 0; i < arraySize; i++)
                    {
                        array[i] = streamReader.ReadLine();
                    }

                    return array;
                }
                else
                {
                    return null;
                }
            }   // Not necessary to close when "using"
        }

        public void Write(string path, string[] cities, string newCity)
        {
            int arraySize = cities.Length;
            string numCities = (arraySize + 1).ToString();

            // Overwrite file:
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(numCities);
            }

            // Append:
            using (StreamWriter streamWriter = new StreamWriter(path, append: true))
            {
                foreach(var city in cities)
                {
                    streamWriter.WriteLine(city);
                }
                streamWriter.WriteLine(newCity);
            }
        }
    }
}
