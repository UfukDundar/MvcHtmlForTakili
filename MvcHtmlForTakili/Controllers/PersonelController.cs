using MvcHtmlForTakili.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHtmlForTakili.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult Yeni()
        {
            return View(new PErsonel());
        }
    }
}