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
        public string Detail()
        {
            return $"Hello from the comic books controller";
        }

    }
}