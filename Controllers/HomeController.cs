using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using deneme.Models.Entity;
using deneme.db_extension;
using deneme.Models.Entity;
using System.Data.Entity;

namespace deneme.Controllers
{
    public class HomeController : Controller
    {
        gpu_databaseEntities db = new gpu_databaseEntities();
        public ActionResult Index()
        {
            var degerler = db.gpu_table.ToList();
            return View(degerler);
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

        public ActionResult Find()
        {
            ViewBag.Message = "Your find page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult GPU()
        {
            var degerler = db.gpu_table.ToList();
            return View(degerler);
        }

        public ActionResult NVIDIA()
        {
            var degerler = db.gpu_table.ToList();
            return View(degerler);
        }

        public ActionResult AMD()
        {
            var degerler = db.gpu_table.ToList();
            return View(degerler);
        }

        public ActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(user_table p2)
        {
            db.user_table.Add(p2);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult addGpu()
        {
            
            List<SelectListItem> degerler = (from i in db.category_table.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CATEGORYNAME,
                                                 Value = i.CATEGORYID.ToString()
                                             }).ToList();

            //var category = db.category_table;
            //ViewBag.dgr = degerler;
           //var table = db.gpu_table;
            ViewDataItems items = new ViewDataItems() {
                //table = table,
                //myvalues = category
                CategoryList = degerler
            };
            return View(items);
        }

        [HttpPost]
        public ActionResult addGpu(gpu_table p1)
        {
            db.gpu_table.Add(p1);
            db.SaveChanges();
            return RedirectToAction("GPU");
            //return Json(new { Result = "Başarılı" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int id)
        {
            var kategori = db.gpu_table.Find(id);
            db.gpu_table.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("GPU");
        }

        public ActionResult Update(int id)
        {
            var ktgr = db.gpu_table.Find(id);
            return View("Update",ktgr);
        }

        public ActionResult UpdateToDB(gpu_table p1)
        {
            var ktg = db.gpu_table.Find(p1.GPUID);
            ktg.GPUNAME = p1.GPUNAME;
            ktg.GPUCATEGORY = p1.GPUCATEGORY;
            ktg.GPUCORECLOCK = p1.GPUCORECLOCK;
            ktg.GPUMEMORYCLOCK = p1.GPUMEMORYCLOCK;
            ktg.GPUMAXMEMORY = p1.GPUMAXMEMORY;
            ktg.GPUPRICE = p1.GPUPRICE;
            ktg.GPUG3D = p1.GPUG3D;
            db.SaveChanges();
            return RedirectToAction("GPU");
        }


        public Nullable<bool> checkResp { get; set; }

        [HttpPost]
        public void Index(FormCollection collection)
        {
           

        }



    }
}