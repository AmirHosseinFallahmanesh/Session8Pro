using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Session8Pro.Controllers
{
    public class student01Controller : Controller
    {
        // GET: student01
        public ActionResult Index()
        {
            return View();
        }

        // GET: student01/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: student01/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: student01/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: student01/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: student01/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: student01/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: student01/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}