using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_assignment.Models;

namespace mvc_assignment.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        Moviesdb mc = new Moviesdb();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Searching(string search)
        {

            var result = mc.movies.Where(x => x.Dateofrelease.Contains(search) || search == null).ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movies movie)
        {
            mc.movies.Add(movie);
            mc.SaveChanges();
            return RedirectToAction("Index");
            TempData.Keep();
            TempData["Message"] = "Record Created";
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movies movies = mc.movies.Find(id);
            return View(movies);
        }

        [HttpPost]
        public ActionResult Edit(Movies movie)
        {
            Movies movies = mc.movies.Find(movie.id);
            movies.Name = movie.Name;
            movies.Dateofrelease = movie.Dateofrelease;
            mc.SaveChanges();
            TempData["Message"] = "Record Updated";
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            Movies movies = mc.movies.Find(id);
            mc.movies.Remove(movies);
            mc.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}