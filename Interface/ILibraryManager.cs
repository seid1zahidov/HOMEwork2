using System;
using System.Collections.Generic;
using System.Text;
using HOMEwork2.Models;

namespace HOMEwork2.Interface
{
    class ILibraryManager
    {
        static List<Book> books;
        static ILibraryManager()
        {
            books = new List<Book>();
        }
    }
}
