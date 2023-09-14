using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.View
{
    /// <summary>
    /// Class <see cref="Gui"/> represents all graphical
    /// </summary>
    internal class Gui
    {
        /// <summary>
        /// Print all available books
        /// </summary>
        /// <param name="availableBooks">list of available books</param>
        public void ShowAvailableBooks(List<string> availableBooks)
        {
            Console.Clear();
            Console.WriteLine("Bøger der kan lånes:");

            for (int i = 0; i < availableBooks.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{i + 1}. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(availableBooks[i]);
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Ask the user for the title of the book they want to loan
        /// </summary>
        public void AskTitleOfBook()
        {
            Console.WriteLine("\nSkriv titlen på den bog du skal bruge:");
        }

        /// <summary>
        /// Prints books added to the to loan list
        /// </summary>
        /// <param name="loanBookList"></param>
        public void ShowLoanList(List<string> loanBookList)
        {
            Console.WriteLine("\nBøger du har tilføjet til dine låne liste:");
            for (int i = 0; i < loanBookList.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{i + 1}. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(loanBookList[i]);
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Prints all lonaned books
        /// </summary>
        /// <param name="loanedBookList">books loaned</param>
        public void ShowLoanedBooks(List<string> loanedBookList)
        {
            Console.Clear();
            Console.WriteLine("\nDu har lige lånt bøgerne:");
            for (int i = 0; i < loanedBookList.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{i + 1}. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(loanedBookList[i]);
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Ask user if they want to loan the books or add more
        /// </summary>
        public void AskLoanOrAddMore()
        {
            Console.Write("\nLån dine tilføjede bøger ved at trykke ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter");
            Console.ResetColor();
            Console.WriteLine(", eller tilføj flere bøger ved at trykke på en anden tast");
        }

        /// <summary>
        /// Prints error if a book isn't available
        /// </summary>
        public void BookError()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nBogen findes ikke");
            Console.ResetColor();
        }
    }
}
