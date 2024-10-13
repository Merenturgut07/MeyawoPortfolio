using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
	public class DefaultController : Controller
	{
		DbMyPortfolioEntities db = new DbMyPortfolioEntities();
		public ActionResult Index()
		{
			return View();
		}
		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}

		public PartialViewResult NavbarPartial()
		{
			return PartialView();
		}

		public PartialViewResult FeaturePartial()
		{
			var values = db.TblFuture.ToList();
			return PartialView(values);
		}

		public PartialViewResult AboutPartial()
		{
			var values = db.TblAbout.ToList();
			return PartialView(values);
		}

		public PartialViewResult ServicePartial()
		{
			var values = db.TblService.ToList();
			return PartialView(values);
		}
		public PartialViewResult ProjectPartial()
		{
			var values = db.TblProject.ToList();
			return PartialView(values);
		}

		public PartialViewResult PricingPartial()
		{
			return PartialView();
		}

		public PartialViewResult SectionPartial()
		{
			return PartialView();
		}

		public PartialViewResult TestimonialPartial()
		{
			var values = db.TblTestimonial.ToList();
			return PartialView(values);
		}

		public PartialViewResult FooterPartial()
		{
			var values = db.TblSocialMedia.ToList();
			return PartialView(values);
		}
		public PartialViewResult ContactPartial()
		{
			var values = db.TblContact.ToList();
			return PartialView(values);
		}

	}
}