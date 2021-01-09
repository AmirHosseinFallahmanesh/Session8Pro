using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session8Pro.Data;
using Session8Pro.Models;

namespace Session8Pro.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepostory repostory;

        public HomeController(IRepostory repostory)
        {
            this.repostory = repostory;
        }
        public IActionResult Index()
        {

           var students= repostory.GetAllStudents();
            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {


            repostory.AddStudent(student);
            return RedirectToAction("Index");
            
        }

        public IActionResult Edit(Guid id)
        {
                var student = repostory.GetStudent(id);
            return View(student);
        }


        [HttpPost]
        public IActionResult Edit(Student student)
        {
            repostory.UpdateStudent(student);
            return RedirectToAction("Index"); ;
        }

        public IActionResult Delete(Guid id)
        {
            repostory.DeleteStudent(id);
            return RedirectToAction("Index"); ;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
