using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class OrderController : Controller
    {
        MusicStoreEntity db = new MusicStoreEntity();
        // GET: Order
        public ActionResult Index()
        {
            var list = db.Orders.Where(p => p.Username == User.Identity.Name);
            return View(list);
        }
        public ActionResult Details(int id)
        {
            var list = db.Orders.Single(p => p.OrderId==id);
            return View(list);
        }
    }
}