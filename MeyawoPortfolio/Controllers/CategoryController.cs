using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class CategoryController : Controller
    {

        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index3()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateCategory() 
        {
            return View();
        }

        [HttpPost]

        public ActionResult CreateCategory(TblCategory p) 
        {
            db.TblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index3");
        }


        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index3");
        }



        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {

            var value = db.TblCategory.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory p)
        {
            var value = db.TblCategory.Find(p.CategoryId);
            value.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index3");
        }


    }
}