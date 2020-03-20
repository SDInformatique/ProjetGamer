using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetGamer.Controllers
{
    public class ConfiguratorController : Controller
    {
        // GET: Configurator
        public ActionResult ConfigType()
        {
            return View();
        }
        public ActionResult ConfigComponent()
        {
            return View();
        }
    }
}