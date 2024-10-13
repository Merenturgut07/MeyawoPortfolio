using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
	public class MessageController : Controller
	{
		// GET: Message
		DbMyPortfolioEntities db = new DbMyPortfolioEntities();

		public ActionResult Index()
		{
			var values=db.TblMessage.ToList();
			return View(values);
		}

		[HttpGet]
		public ActionResult CreateMessage()
		{
			return View();
		}
		[HttpPost]
		public ActionResult CreateMessage(TblMessage p)
		{
			db.TblMessage.Add(p);
			db.SaveChanges();
			return RedirectToAction("Index");

		}
	}
}