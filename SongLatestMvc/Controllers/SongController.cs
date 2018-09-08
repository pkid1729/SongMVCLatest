using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SongLatestMvc.Models;

namespace SongLatestMvc.Controllers
{
    [Route("song")]
    public class SongController : Controller
    {
       // private DataContext db = new DataContext();
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
          //  ViewBag.songs = db.Songs.ToList();
            return View();
        }
    }
}