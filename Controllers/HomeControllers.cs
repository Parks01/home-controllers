using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
    public class HomeController : Controller
    {
      // [Route("/")]
      public ActionResult Index()
      {
        return View();
      }


    }
}
