using H1_Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bog1 = new Book("Anders And", 102);
            Book bog2 = new Book("Hvalen Umut", 35);
            Book bog3 = new Book("Aben Andreas", 243);

            List<Book> booksToLoan = new List<Book>()
            {
                bog1, bog2, bog3
            };

            Stack<Book> booksLoaned = new Stack<Book>();
            Console.WriteLine("Skriv titlen på bogen du vil låne");

            string loanBook = Console.ReadLine();
            bool foundBook = false;

            for(int i = 0; i < booksToLoan.Count; i++)
            {
                if (booksToLoan[i].Title == loanBook)
                {
                    booksLoaned.Push(booksToLoan[i]);
                    foundBook = true;
                }
            }
            if(foundBook)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nBogen ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"({loanBook})");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" blev fundet, og er tilføjet til listen, vil du låne flere?");

                Console.WriteLine("Tryk Y for at finde flere bøger, eller alle for at låne alle de valgte bøger");
                Console.ResetColor();
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du har nu lånt:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    foreach (Book book in booksLoaned)
                    {
                        Console.WriteLine(book.Title);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
