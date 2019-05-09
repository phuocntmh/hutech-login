using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HUTECH.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if (username=="1511060249" && password=="123456")
                return RedirectToAction("Index", "Home");
            ModelState.AddModelError("","Tài khoàn không đúng, vui lòng thử lại!");
            return View("Index");
        }
    }
}