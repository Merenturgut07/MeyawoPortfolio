using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;
namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            //Aggregate--> sum count avg min max
            ViewBag.categoryCount=db.TblCategory.Count();
            ViewBag.projectCount=db.TblProject.Count();
            ViewBag.messageCount=db.TblContact.Count();
            ViewBag.flutterProjectCount=db.TblProject.Where(x=> x.ProjectCategory == 1).Count();

            ViewBag.isNotReadMessageCount=db.TblContact.Where(x=> x.IsRead==false).Count();
            ViewBag.messageCount = db.TblContact.Count();

            ViewBag.lastProjectName = db.lastProjectName().FirstOrDefault();


            ViewBag.testimonialCount = db.TblTestimonial.Count();
            return View();
        }
    }
}