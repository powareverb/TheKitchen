using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheKitchen.Services;

namespace TheKitchen.Web.Controllers
{
    public class RecipeBookController : Controller
    {
        IRecipeBookService _svc;
        public RecipeBookController(IRecipeBookService svc)
        {
            _svc = svc;
        }

        //
        // GET: /RecipeBook/
        public ActionResult Index()
        {
            var books = _svc.GetAllRecipeBooks();
            return View(books);
        }

        //
        // GET: /RecipeBook/Details/5

        public ActionResult Details(int id)
        {
            var books = _svc.ById(id);
            return View(books);
        }

        //
        // GET: /RecipeBook/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RecipeBook/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RecipeBook/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /RecipeBook/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RecipeBook/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /RecipeBook/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
