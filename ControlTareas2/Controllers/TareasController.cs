﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlTareas2.Controllers
{
    public class TareasController : Controller
    {
        // GET: Tareas
        public ActionResult Index()
        {
            return View();
        }
    }
}