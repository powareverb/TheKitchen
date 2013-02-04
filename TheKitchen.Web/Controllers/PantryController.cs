using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheKitchen.Web.Controllers
{
    public class PantryController : Controller
    {
        //
        // GET: /Pantry/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Pantry/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pantry/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pantry/Create

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
        // GET: /Pantry/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pantry/Edit/5

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
        // GET: /Pantry/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pantry/Delete/5

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
