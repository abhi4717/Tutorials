using MVC_Tutorial.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            List<Album> albumList = GetAlbumList();

            return View(albumList);
        }

        private static List<Album> GetAlbumList()
        {
            return new List<Album>() {new Album() { Artist = "Artist 1", Title ="Test Title 1", Price = 12 },
                new Album() { Artist = "Artist 2", Title ="Test Title 2", Price = 10 },
                new Album() { Artist = "Artist 3", Title ="Test Title 3", Price = 9 },
            };
        }

        public ActionResult Search(SearchViewModel searchParameter)
        {
            if (ModelState.IsValid)
            {
                var albumList = GetAlbumList();
                return View("Index", albumList.FindAll(x => x.Title.ToLower().Contains(searchParameter.Title.ToLower())));
            }
            else
                return View("Index", GetAlbumList());
        }

        public ActionResult ServiceTest()
        {
            
            return View();
        }
    }
}