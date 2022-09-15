using MiniCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniCursos.Controllers
{
    public class CursosController : Controller
    {
        bdCursosEntities bd = new bdCursosEntities();
        // GET: Cursos
        public ActionResult Index()
        {
            if (Session["MyCurso"] != null)
            {
                ViewBag.qtdCursos = bd.Cursos.ToList().Count();
                return View(bd.Cursos.ToList());
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        public ActionResult DisciplinaPorCurso(int? id)
        {
            if (Session["MyCurso"] != null)
            {
                return View(bd.Disciplinas.ToList().Where(x => x.CURSOID == id));
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
    }
}