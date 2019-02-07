using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{

    public class FileUtility : IFileUtility
    {
        // Make sure the class impliments IFileUtility: see above

        // Add a private string field called _filePath
        private string _filePath;

        // Add a constructor that takes a string parameter called path
        public FileUtility(string path)
        {
            // Set your private field to the path passed in
            _filePath = path;
        }


        public string ReadFromFile()
        {
            // Add a string variable called fileContents
            string fileContents;

            // Add a using statement: see top of file
            using ( StreamReader streamReader = new StreamReader(_filePath) )
            {
                // Inside of the using statment, create a StreamReader.
                // The stream read constructor will take the path property: see parameter above

                // Set the fileContents variable to the file using stream readers 'ReadToEnd' method
                fileContents = streamReader.ReadToEnd();
            }

            // Return the fileContents
            return fileContents;
        }

        public void WriteToFile(string value)
        {
            // Add a using statement
            using ( StreamWriter streamWriter = new StreamWriter(_filePath) )
            {
                // Inside of the using, create a new StreamWriter.
                // The stream writer's constructor take the private file path field: see above

                // Write the value parameter to the file using the writer's 'Write' method
                streamWriter.Write(value);
            }
        }
    }
}