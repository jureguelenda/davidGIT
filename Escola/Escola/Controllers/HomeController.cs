using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Escola.Controllers
{
    public class HomeController : Controller
    {
        BDCURSOEntities bd = new BDCURSOEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult VerificarLogin(string login, string senha)
        {
            bool validade = true;
            if (validade == true)
            {
                Session["MyCurso"] = "Logado";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.textoErro = "Login ou senha incorreto";
                return RedirectToAction("Login");
            }
        }

        public ActionResult DashboardCursos()
        {
            if (Session["MyCurso"] != null)
            {
                return View(bd.GrupoCursoQuantidadeDisciplina.ToList());
            }
            else
            {
              return RedirectToAction("Login","Home");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}