﻿using System;
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
        public ActionResult ConfigPrimaryComponents()
        {
            return View();
        }
        public ActionResult ConfigStorage()
        {
            return View();
        }

        public ActionResult ConfigChecklist()
        {
            return View();
        }

        #region Choices

        public ActionResult CaseChoice()
        {
            return View();
        }

        public ActionResult MotherboardChoice()
        {
            return View();
        }

        #region CPU & CPU Cooling
        public ActionResult CpuChoice()
        {
            return View();
        }
        public ActionResult CpuCoolingChoice()
        {
            return View();
        }
        public ActionResult AirCoolingChoice()
        {
            return View();
        }
        public ActionResult WatercoolingType()
        {
            return View();
        }
        public ActionResult WatercoolingConfig()
        {
            return View();
        }
        public ActionResult CustomWatercoolingConfig()
        {
            return View();
        }
        #endregion

        public ActionResult GpuChoice()
        {
            return View();
        }

        #region Storage
        public ActionResult StorageTypeChoice()
        {
            return View();
        }
        public ActionResult HDDChoice()
        {
            return View();
        }
        public ActionResult SSDChoice()
        {
            return View();
        }
        #endregion
        public ActionResult PSUChoice()
        {
            return View();
        }

        #endregion
    }
}