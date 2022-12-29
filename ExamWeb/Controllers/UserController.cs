using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamWeb.Controllers
{
    public class UserController : Controller
    {
        // GET: User
      
        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult Cuenta()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public JsonResult OptionsProfile(string ValueOpcion)
        {
            string opcion = "";
            switch (ValueOpcion)
            {
                case "1":
                    opcion = "Cuenta";
                    return Json(new { opcion = opcion });
                case "2":
                    opcion = "ChangePassword";
                    return Json(new { opcion = opcion });
                default:
                    opcion = "UserProfile";
                    return Json(new { opcion = opcion });
            }

        }
    }
}