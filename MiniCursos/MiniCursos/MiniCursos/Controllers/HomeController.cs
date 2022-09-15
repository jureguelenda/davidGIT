using MiniCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniCursos.Controllers
{
    public class HomeController : Controller
    {
        bdCursosEntities bd = new bdCursosEntities();
        public ActionResult Index()
        {
            if (Session["MyCurso"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");

            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VerificarLogin(string login,string senha)
        {

            foreach(var item in bd.Colaborador)
            {
                if((item.collogin==login) && (item.colsenha == senha))
                {
                    Session["MyCurso"] = "MyCurso";
                    return RedirectToAction("Index");
                }
            }

                ViewBag.textoErro = "Login ou senha incorreto";
                return RedirectToAction("Login");
            
        }

        public ActionResult DashboadCursos()
        {
           if (Session["MyCurso"] != null)
            {
                return View(bd.GrupoCursoQuantidadeDisciplina.ToList());
            }
            else
            {
                return RedirectToAction("Login", "Home");
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