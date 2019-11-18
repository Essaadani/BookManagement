using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        Book GetByTitle(string title);
        void Add(Book book);
        void Update(int id, Book newBook);
        void Delete(int id);
        IEnumerable<Book> Search(string txtSearch);
    }
}
