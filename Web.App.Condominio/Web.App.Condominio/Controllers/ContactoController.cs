﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.App.Condominio.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        public ActionResult ContactoPublico()
        {
            return View();
        }
    }
}