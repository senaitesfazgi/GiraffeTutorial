using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GiraffeTutorial
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        
    }
}
