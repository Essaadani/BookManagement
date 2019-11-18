using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;

namespace BookManagement.Repositories
{
    public class SqlServerRepository : IBookRepository
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> Search(string txtSearch)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Book newBook)
        {
            throw new NotImplementedException();
        }
    }
}
