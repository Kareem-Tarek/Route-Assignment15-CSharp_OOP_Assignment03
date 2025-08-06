using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session07.Classes
{
    internal class PrintedBook : Book
    {
        // Properties
        public int PageCount { get; set; }

        // Constructors (Constructor Chaining)
        public PrintedBook(int id, string title, string author, string isbn, int pageCount)
            : base(id, title, author, isbn)
        {
            PageCount = pageCount;
        }

        // Methods
        public override void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nPage Count: {PageCount}");
        }
    }
}
