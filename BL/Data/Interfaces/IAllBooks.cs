using BL.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Data.Interfaces
{
    interface IAllBooks
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> getFavBooks { get; set; }
        Book getObjectBook(int bookID);
    }
}
