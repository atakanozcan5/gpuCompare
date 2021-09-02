using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using deneme.Models.Entity;

namespace deneme.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        gpu_databaseEntities db = new gpu_databaseEntities();
        public ActionResult Index()
        {
            var degerler = db.user_table.ToList();
            return View(degerler);
        }
    }
}