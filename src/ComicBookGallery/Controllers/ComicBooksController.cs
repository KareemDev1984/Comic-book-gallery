using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ComicBookGallery.Controllers
{
    //the comicbookscontroller class we added inherits from controller class (using system.web.mvc)
    //controllerclasses need to be public otherwise MVC won't be able to find and use them.
    public class ComicBooksController : Controller
    {
        private ComikBookRepository _comikBookRepository = null;
        public ComicBooksController()
        {
            _comikBookRepository = new ComikBookRepository();

        }

        public ActionResult Index()
        {
            var comicBooks = _comikBookRepository.GetComicBooks();
            return View(comicBooks);
        }
        //ActionMethods need to be public too!!
        //contentresult and redirectresult havce a common baseClass ==> ActionResult base class
        //because of this ActionResult is almost always used as the returnType
        public ActionResult Detail(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            //{
            //    //return new RedirectResult("");
            //    //return Redirect("/"); //we can call the redirect method that is part of our controllerclass
            //}


            //return Content("Hello from the comic books controller");


            // not neccesary! we can directly call the Content() method that is part of the controllerclass
            //return new ContentResult()
            //{ Content= "Hello from the comic books controller" };

            //return new ViewResult();
            var comicBook = _comikBookRepository.GetComicBook((int)id);
            return View(comicBook);


            //ViewBag.SeriesTitle = "The Amazing Spider-Man";
            //ViewBag.IssueNumber = 700;
            //ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            //ViewBag.Artists = new string[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //};
            //return View();


        }

    }
}