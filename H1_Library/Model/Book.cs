using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.Model
{
    /// <summary>
    /// Class <see cref="Book"/> represents a book
    /// </summary>
    internal class Book
    {
        private string _title;
        private ushort _pageAmount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class, using multiple arguments
        /// </summary>
        /// <param name="title"></param>
        /// <param name="pageAmount"></param>
        public Book(string title, ushort pageAmount)
        {
            _title = title;
            _pageAmount = pageAmount;
        }

        public string Title
        {
            get { return _title; }
        }
    }
}
