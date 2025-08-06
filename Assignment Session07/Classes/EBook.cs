using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session07.Classes
{
    internal class EBook : Book
    {
        // Properties
        public double FileSize { get; set; }

        // Constructors (Constructor Chaining)
        public EBook(int id, string title, string author, string isbn, double fileSize)
            : base(id, title, author, isbn)
        {
            FileSize = fileSize;
        }

        // Methods
        public override void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nFile Size: {FileSize}");
        }
    }
}
