using MusicStoreSites.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreSites.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        IAlbumService albumService;
        IGenreService genreService;

        public HomeController(IAlbumService album,IGenreService genre)
        {
            albumService = album;
            genreService = genre;
        }

        // GET: Home
        public ActionResult Index()  //tüm albümler listelensin
        {
            var albums = albumService.GetAll();
            return View(albums);
        }

        public ActionResult _GenreMenu()
        {
            return PartialView(genreService.GetAll());
        }

    }
}