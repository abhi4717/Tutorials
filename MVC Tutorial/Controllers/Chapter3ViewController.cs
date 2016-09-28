using MVC_Tutorial.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class Chapter3ViewController : Controller
    {
        // GET: Chapter3View
        public ActionResult Index()
        {
            ViewBag.Artist = new List<Album>() { new ViewModel.Album() { Artist = "Artist 1", Price = 10, Title = "Test Title 1" } };
            return View();
        }
    }
}