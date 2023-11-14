using BooksManagement.App.Interfaces;
using BooksManagement.App.ViewModels;
using BooksManagement.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksManagement.WebApplication.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorApp _authorApp;

        public AuthorController(IAuthorApp authorApp)
        {
            _authorApp = authorApp;
        }

        // GET: AuthorController
        public async Task<IActionResult> Index()
        {
            var authors = await _authorApp.GetAll();
            return View(authors);
        }

        // GET: AuthorController/Details/5
        public async Task<IActionResult> Details(long id)
        {
            var author = await _authorApp.GetById(id);
            return View(author);
        }

        // GET: AuthorController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AuthorViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid) return View(viewModel);

                await _authorApp.Create(viewModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(viewModel);
            }
        }

        // GET: AuthorController/Edit/5
        public async Task<IActionResult> Edit(long id)
        {
            var author = await _authorApp.GetById(id);
            return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AuthorViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid) return View(viewModel);

                await _authorApp.Update(viewModel);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(viewModel);
            }
        }

        // GET: AuthorController/Delete/5
        public async Task<IActionResult> Delete(long id)
        {
            var author = await _authorApp.GetById(id);
            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id, IFormCollection collection)
        {
            try
            {
                if (!ModelState.IsValid) return View(collection);

                await _authorApp.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(collection);
            }
        }
    }
}
