using projektzaginione.DAL;
using projektzaginione.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace projektzaginione.Controllers
{
    public class LosePeopleController : Controller
    {
        private dataContext db = new dataContext();
        // GET: LosePeople
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(db.LosePeople.ToList());
        }
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Imie, Nazwisko, Wiek, Opis, Data_zaginiecia, Znaki_szczegolne, Lokalizacja")]LosePeople losepeople)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.LosePeople.Add(losepeople);
                    db.SaveChanges();
                    return RedirectToAction("List");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(losepeople);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LosePeople losepeople = db.LosePeople.Find(id);
            if (losepeople == null)
            {
                return HttpNotFound();
            }
            return View(losepeople);
        }

    }
}