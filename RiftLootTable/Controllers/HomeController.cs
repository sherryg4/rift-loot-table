using RiftLootTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RiftLootTable.Controllers
{
    public class HomeController : Controller
    {
        private RiftLootTableContext _context;

        public HomeController(RiftLootTableContext context)
        {
            this._context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}