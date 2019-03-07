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
        //ActionMethods need to be public too!!
        //contentresult and redirectresult havce a common baseClass ==> ActionResult base class
        //because of this ActionResult is almost always used as the returnType
        public ActionResult Detail() 
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                //return new RedirectResult("");
                return Redirect("/"); //we can call the redirect method that is part of our controllerclass
            }
            return Content("Hello from the comic books controller");


            // not neccesary! we can directly call the Content() method that is part of the controllerclass
            //return new ContentResult()
            //{ Content= "Hello from the comic books controller" };

          
        }

    }
}