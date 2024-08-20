using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class FutureController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblFuture.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateFuture()
        {
            return View();
        }

        [HttpPost]

        public ActionResult CreateFuture(TblFuture p)
        {
            db.TblFuture.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteFuture(int id)
        {
            var value = db.TblFuture.Find(id);
            db.TblFuture.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateFuture(int id)
        {

            var value = db.TblFuture.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateFuture(TblFuture p)
        {
            var value = db.TblFuture.Find(p.FutureId);
            value.Header = p.Header;
            value.NameSurname = p.NameSurname;
            value.Title = p.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}