using System;
using System.Collections.Generic;
using System.Text;
using HOMEwork2.Interface;
using HOMEwork2.Models;

namespace HOMEwork2.Service
{
    class librarymeneger : ILibraryManager
    {
        List<Book> _books;

        public librarymeneger()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (_books.Count < 0 || _books.Exists(b => b.Name == book.Name))
            {
                _books.Add(book);

            }

        }
    }
}
