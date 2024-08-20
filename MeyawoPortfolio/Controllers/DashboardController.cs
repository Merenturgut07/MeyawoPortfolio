using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;
namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.TestimonialCount = db.TblTestimonial.Count();
            ViewBag.ServiceCount = db.TblService.Count();

            return View();
        }
    }
}