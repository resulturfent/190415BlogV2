using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _190410_BlogV1.Controllers
{
    public class MakalelerController : Controller
    {
        //*****************************************************************
        Models.Bloghi304DBEntities1 db = new Models.Bloghi304DBEntities1();
        // GET: Makaleler
        public ActionResult MakaleListesIndex()
        {
            return View();
        }

        public ActionResult KategoriListeiIndex()
        {
            return View();
        }

        public ActionResult KategoriListesi()
        {

            return View(db.Kategoriler.ToList());
        }
    }
}