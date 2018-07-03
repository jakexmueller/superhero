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
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Superhero
        public ActionResult Index()
        {
            
            //Superhero ironMan = new Superhero();

            var heroes = db.Superhero.ToList();
            return View(heroes);
        }

        //GET superheroes/Create
        public ActionResult Create()
        {

            return View();
        }

        //POST: superheroes/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name, AlterEgo,PrimaryAbility,SecondaryAbility,CatchPhrase")] Superhero superhero)
        {
            db.Superhero.Add(superhero);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        //edit(int)
        //GET superheroes/Edit
        public ActionResult Edit(int? id)
        {
            //Superhero superhero = ;
           // var test = db.Superhero.Where(s => s.ID == id).FirstOrDefault();
            var heroToEdit = db.Superhero.Find(id);
            return View(heroToEdit);
        }
        //POST: superheroes/edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name, AlterEgo,PrimaryAbility,SecondaryAbility,CatchPhrase")] Superhero heroToEdit)
        {

            //Superhero heroToEdit = new Superhero();
            var foundHero = db.Superhero.Where(s => s.ID == heroToEdit.ID).FirstOrDefault();
            foundHero.Name = heroToEdit.Name;
            foundHero.AlterEgo = heroToEdit.AlterEgo;
            foundHero.PrimaryAbility = heroToEdit.PrimaryAbility;
            foundHero.SecondaryAbility = heroToEdit.SecondaryAbility;
            foundHero.CatchPhrase = heroToEdit.CatchPhrase;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        //delete(int)
        public ActionResult Delete(int? ID)
        {
            //Superhero superhero = new Superhero();
            return View();
        }

        //details
        public ActionResult Details(int id)
        {
            var heroToView = db.Superhero.Find(id);
            return View(heroToView);
        }


    }
}