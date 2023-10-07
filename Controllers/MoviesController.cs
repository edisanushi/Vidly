using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movies() { Id = 1, Title = "Shrek" };
            //return RedirectToAction("Index", "Home", new {page=1, sortBy = "name"}); 
            //return HttpNotFound();
            //return Content("Hello World");
            return View(movie);
        }



        //Can get accessed both ways:
        //1:   /Movies/Edit?id=1
        //2:   /Movies/Edit/1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }



        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}