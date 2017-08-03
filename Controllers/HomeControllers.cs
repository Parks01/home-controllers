using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
        return View();
      }

      [Route("/createArtist")]
      public ActionResult CreateNewArtist()
      {
        string artistName = Request.Form["artist-name"];
        string cdName = Request.Form["cd-name"];

        Artist artist = new Artist(artistName);
        return View(artist);
      }

      [Route("/artistList")]
      public ActionResult ArtistList()
      {
        List<Artist> artistList = Artist.GetAllArtist();
        return View(artistList);
      }
    }
}
