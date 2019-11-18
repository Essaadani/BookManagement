using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Repositories
{
    public class BookRepository:IBookRepository
    {
        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id=1,
                    Title = "Java Programming",
                    Author ="Zouhair",
                    IsAvailable = true,
                    Price=30,
                    PublishedAt = new DateTime(2020,03,12),
                    Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English."
                },
                new Book
                {
                    Id=2,
                    Title = "C# Programming",
                    Author ="Khalid",
                    IsAvailable = false,
                    Price=15,
                    PublishedAt = new DateTime(2012,06,12),
                    Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English."
                },
                new Book
                {
                    Id=3,
                    Title = "Python Programming",
                    Author ="Ahmed",
                    IsAvailable = true,
                    Price=45,
                    PublishedAt = new DateTime(2007,09,22),
                    Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English."
                }
            };
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Delete(int id)
        {
            var bookToDelete = GetById(id);

            books.Remove(bookToDelete);
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public Book GetById(int id)
        {
            var bookToFind = books.Where(a => a.Id == id).SingleOrDefault();

            return bookToFind;
        }

        public Book GetByTitle(string title)
        {
            var bookToFind = books.Where(b => b.Title == title).SingleOrDefault();

            return bookToFind;
        }

        public IEnumerable<Book> Search(string txtSearch)
        {
            var book = books.Where(t => t.Title.ToLower().Contains(txtSearch.ToLower())
                                     || t.Author.ToLower().Contains(txtSearch.ToLower()));

            return book;
        }

        public void Update(int id, Book newBook)
        {
            var oldBook = GetById(id);
            oldBook.Title = newBook.Title;
            oldBook.Author = newBook.Author;
            oldBook.IsAvailable = newBook.IsAvailable;
            oldBook.Price = newBook.Price;
            oldBook.PublishedAt = newBook.PublishedAt;
        }
    }
}
