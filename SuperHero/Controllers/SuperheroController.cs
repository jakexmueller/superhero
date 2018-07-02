using SuperHero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHero.Controllers
{
    public class SuperheroController : Controller
    {
        // GET: Superhero
        public ActionResult Index()
        {
            Superhero ironMan = new Superhero();
            List<Superhero> superHeroes = new List<Superhero>();
            return View(ironMan);
        }

        //create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }
        
        //edit(int)
        public ActionResult Edit(int ID)
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }
        
        //delete(int)
        public ActionResult Delete(int ID)
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }


    }
}