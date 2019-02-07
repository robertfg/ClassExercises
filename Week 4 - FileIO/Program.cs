using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4_FileIO
{
    class Program
    {
        private static int numPages;
        private static double currentPage;

        static void Main(string[] args)
        {
            bool res;
            Book book = new Book();

            // try-catch is overkill here:
            try
            {
                Console.Write("Enter the title: ");
                book.title = Console.ReadLine();
                if ( String.IsNullOrEmpty(book.title) )
                {
                    book.title = "No title entered.";
                }

                //Console.Write("Number of pages: ");
                //book.numPages = int.Parse(Console.ReadLine());
                //Console.Write("Page you are on: ");
                //book.currentPage = double.Parse(Console.ReadLine());

                Console.Write("Number of pages: ");
                if (!int.TryParse(Console.ReadLine(), out numPages))
                {
                    book.numPages = 0;
                }
                else
                {
                    book.numPages = numPages;
                }

                Console.Write("Page you are on: ");
                if (!double.TryParse(Console.ReadLine(), out currentPage))
                {
                    book.currentPage = 0;
                }
                else
                {
                    book.currentPage = currentPage;
                }
            }
            catch (FormatException ex)
            {
                throw new Exception("You need to enter a numeric value.  Error: " + ex.Message);
            }

            //Console.WriteLine(book.title + " " + book.numPages + " " + book.currentPage);
            book.OutputTofile();

            Console.WriteLine();
            Console.WriteLine("Writing to file....");
            Console.ReadKey();
        }
    }
}
