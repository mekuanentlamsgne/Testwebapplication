﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gitTest.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {

        String var="";
         String var="testtestfro taye taking back";
        


            viewbag.message = "Hello World";

            return View();
        }
    }
}
