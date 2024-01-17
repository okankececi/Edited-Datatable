using dataTable_edited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dataTable_edited.Controllers
{
    public class HomeController : Controller
    {
        public PCEntities db = new PCEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            var result = db.trn_kanban_productivity.ToList();
            return View(result);
        }
    }
}