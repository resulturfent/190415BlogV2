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
        Models.Bloghi304DBEntities1 DB = new Models.Bloghi304DBEntities1();
        // GET: Makaleler
        public ActionResult MakaleListesiIndex()
        {
            return View(DB.Makaleler.ToList());
        }

        public ActionResult MakaleDetayIndex(int id)
        {
            //var makaleId = RouteData.Values["id"];
            var makaleDetay = DB.Makaleler.Where(m => m.MakalelerID == id).FirstOrDefault();

            ViewBag.Yazar = DB.Uyeler.Where(y => y.UyelerID == makaleDetay.YazarID && y.YazarMi == true).FirstOrDefault().Adi;
            //ViewBag.Resim = DB.Resimler.Where(r => r.MakaleID == id).FirstOrDefault().BuyukBoyut;
            return View(makaleDetay);
        }

        public ActionResult YorumListesi(int id)
        {
            var Yorumlar = DB.Yorumlar.Where(k => k.MakaleID == id).ToList();
            return View(Yorumlar);
        }

        public ActionResult KategoriListeiIndex()
        {
            return View();
        }

        public ActionResult KategoriListesi()
        {

            return View(DB.Kategoriler.ToList());
        }
    }
}