﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSMVCMSSQL.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult User_Index()
        {
            return View();
        }

        public ActionResult User_Create()
        {
            return View();
        }

        public ActionResult User_Update()
        {
            return View();
        }

        public ActionResult User_Delete()
        {
            return View();
        }

    }
}