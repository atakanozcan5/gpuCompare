using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using deneme.Models.Entity;

namespace deneme.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Default
        gpu_databaseEntities db = new gpu_databaseEntities();
        public ActionResult category()
        {
            var degerler = db.category_table.ToList();
            return View(degerler);
        }
    }
}