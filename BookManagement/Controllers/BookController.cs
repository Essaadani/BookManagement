using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Models;
using BookManagement.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    public class BookController : Controller
    {
        IBookRepository repo;

        public BookController(IBookRepository _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            var books = repo.GetAll();

            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = repo.GetById(id);

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            repo.Add(book);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var book = repo.GetById(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            repo.Delete(id);

            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            var book = repo.GetById(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id, Book newBook)
        {
            repo.Update(id, newBook);

            return RedirectToAction("Index");
        }

        public IActionResult Search(string txtSearch)
        {
            var book = repo.Search(txtSearch);

            return View("Index", book);
        }




    }
}