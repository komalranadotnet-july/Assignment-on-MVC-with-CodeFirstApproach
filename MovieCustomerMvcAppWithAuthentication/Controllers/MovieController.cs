using MovieCustomerMvcAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace MovieCustomerMvcAppWithAuthentication.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
            // GET: Movie
            public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var singleMovie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (singleMovie == null)
                return HttpNotFound();
            return View(singleMovie);
        }


    }
}