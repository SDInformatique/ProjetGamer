using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetGamer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PCPreBuilt_List()
        {
            ViewBag.Message = "PC Gamer";
            return View();
        }
        public ActionResult SRVPreBuilt_List()
        {
            ViewBag.Message = "Serveur";
            return View();
        }
        public ActionResult Configurator()
        {
            ViewBag.Message = "Configurator";
            return View();
        }
        public ActionResult UserProfile()
        {
            ViewBag.Message = "Votre Profile";
            return View();
        }
        public ActionResult MyOrder()
        {
            ViewBag.Message = "Vos Commandes";
            return View();
        }
        public ActionResult MyConfiguration()
        {
            ViewBag.Message = "Vos Configuration";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login";
            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Register";
            return View();
        }
    }
}