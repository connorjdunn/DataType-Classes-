using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //FIELD
        //Automatic because no buisness rules

        //PROPERTIES
        public string Title { get; set; }

        public string Author { get; set; }

        public int NumberOfPages { get; set; }

        //CONSTRUCTORS
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        //METHODS

        public override string ToString()
        {
            // return base.ToString();
            return Title;
            
        }
    }
}
