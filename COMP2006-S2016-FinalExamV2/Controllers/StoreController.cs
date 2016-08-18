using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2006_S2016_FinalExamV2.Models;
using System.Diagnostics;

namespace COMP2006_S2016_FinalExamV2.Controllers
{
    /**Made By Gurpanth Singh
Final Exam
Student No. 200299024
Music Stroe Update
**/
    public class StoreController : Controller
    {
        private MVCMusicStoreContext storeDB = new MVCMusicStoreContext();

        // GET: Store
        public ActionResult Index()
        {
            List<Genre> genres = storeDB.Genres.ToList();
            return View(genres);
        }

        public ActionResult Browse(string Genre)
        {
            //Debug.WriteLine(type);
            Genre genres = storeDB.Genres.Include("Genre").Single(g => g.Name == Genre);
            return View(genres);
        }
        public ActionResult Details(int id = 1)
        {
            
            Album album = storeDB.Albums.Find(id);
            return View(album);
        }
    }
}