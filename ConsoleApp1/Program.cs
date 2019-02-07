using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what they would like to call their file.  
            // You probably want to bracket this with a try/catch to see if it's a valid filename.
            Console.WriteLine("What would you like to call your file?");

            // Store the input in variable called "fileName"
            string fileName = Console.ReadLine();

            // Append .txt to the end of fileName
            fileName += ".txt";

            // Create a File utility object here
            // Give it the fileName object.
            FileUtility fileUtility = new FileUtility(fileName);

            // Ask the user for data to put into the file
            Console.WriteLine("Input data for file.");

            // Store the user input in a variable called data
            // Good spot for another try/catch
            string data = Console.ReadLine();

            // Write the data to the file using your fileUtility
            fileUtility.WriteToFile(data);

            // Give a message to the user telling them data was written to the file
            Console.WriteLine("Data was written to file.");

            // Display the data from the file
            Console.WriteLine( fileUtility.ReadFromFile() );

            // Add Console.ReadKey to make sure that the console window doesn't close
            Console.ReadKey();
        }
    }
}