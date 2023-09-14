using H1_Library.Model;
using H1_Library.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> is the main controller of the program. Its purpose is to give assigments to view, model and other controllers
    /// </summary>
    internal class MainController
    {
        /// <summary>
        /// Starts the controller and the program
        /// </summary>
        public void Start()
        {
            List<Book> bookLoanList = CreateNewLoanList();
            List<string> bookLoanListTitles = new List<string>();

            Gui gui = new Gui();

            // Put all books by their title in a list
            foreach(Book book in bookLoanList)
            {
                bookLoanListTitles.Add(book.Title);
            }

            // Shows all available books
            gui.ShowAvailableBooks(bookLoanListTitles);

            UserInput userInput = new UserInput();

            // Books the user want to loan, but hasn't loaned
            Stack<Book> booksToLoan = new Stack<Book>();

            // Titles of books the user want to loan, but hasn't loaned
            List<string> booksToLoanTitles = new List<string>();

            // Gets all books the user wants to loan
            while (true)
            {
                // Asks the user to choose a book to loan by the book's title
                gui.AskTitleOfBook();

                string titleOfBookToLoan = userInput.GetInput();
                if (bookLoanListTitles.Contains(titleOfBookToLoan))
                {
                    byte bookIndex = (byte)bookLoanListTitles.IndexOf(titleOfBookToLoan);

                    // Push book into user's book loan list
                    booksToLoan.Push(bookLoanList[bookIndex]);

                    // Remove book from loan list and book title list
                    bookLoanList.RemoveAt(bookIndex);
                    bookLoanListTitles.RemoveAt(bookIndex);

                    // Put all loaned books by their title in a list
                    foreach (Book book in booksToLoan)
                    {
                        booksToLoanTitles.Add(book.Title);
                    }

                    gui.ShowAvailableBooks(bookLoanListTitles);
                    gui.ShowLoanList(booksToLoanTitles);
                    gui.AskLoanOrAddMore();

                    if (userInput.GetPressedKey() == ConsoleKey.Enter)
                    {
                        break;
                    }
                    booksToLoanTitles.Clear();
                }
                else
                {
                    gui.BookError();
                }
            }

            // Shows loaned books
            gui.ShowLoanedBooks(booksToLoanTitles);

            // Removes books from stack which is the list which contains books to loan
            for(int i = 0; i < booksToLoanTitles.Count; i++)
            {
                booksToLoan.Peek();
                booksToLoan.Pop();
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Creates a new loan list filled with books
        /// </summary>
        /// <returns></returns>
        private List<Book> CreateNewLoanList()
        {
            Book bog1 = new Book("Anders And", 102);
            Book bog2 = new Book("Hvalen Umut", 35);
            Book bog3 = new Book("Aben Andreas", 243);

            List<Book> booksAvailable = new List<Book>()
            {
                bog1, bog2, bog3
            };

            return booksAvailable;
        }
    }
}
