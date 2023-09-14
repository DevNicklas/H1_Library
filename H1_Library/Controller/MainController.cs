using H1_Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.Controller
{
    internal class MainController
    {
        public void Start()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Book> CreateNewLoanList()
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
