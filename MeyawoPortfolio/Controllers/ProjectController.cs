﻿ using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            List<SelectListItem> values = (from x in db.TblCategory.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString(),
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            List<SelectListItem> values1 = (from x in db.TblCategory.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString(),
                                            }).ToList();
            ViewBag.v = values1;

            var value = db.TblProject.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var value = db.TblProject.Find(p.ProjectId);
            value.Description = p.Description;
            value.imageUrl = p.imageUrl;
            value.ProjectCategory = p.ProjectCategory;
            value.ProjectUrl = p.ProjectUrl;
            value.Title = p.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteProject(int id)
        {
            var value = db.TblProject.Find(id);
            db.TblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}