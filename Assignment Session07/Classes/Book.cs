using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session07.Classes
{
    internal class Book
    {
        // Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Constructors (Parameterized Constructor)
        public Book(int id, string title, string author, string iSBN)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        // Methods
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}");
        }

    }
}
