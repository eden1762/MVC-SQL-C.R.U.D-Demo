using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSMVCMSSQL.Controllers
{
    public class NationController : Controller
    {
        // GET: Nation
        public ActionResult Nation_Index()
        {
            return View();
        }
        public ActionResult Nation_Create()
        {
            return View();
        }
        public ActionResult Nation_Delete()
        {
            return View();
        }
    }
}