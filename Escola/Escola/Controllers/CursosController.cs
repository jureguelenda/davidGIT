using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Escola.Controllers
{
    public class CursosController : Controller
    {
        BDCURSOEntities bd = new BDCURSOEntities();

        // GET: Cursos
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.qtdCursos = bd.Cursos.ToList().Count();

            return View(bd.Cursos.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(int? ID, string Curso, string Habilidade, string Modalidade)
        {
            Cursos novoCursos = new Cursos();
            novoCursos.CURSOID = Convert.ToInt32(ID);
            novoCursos.CURSODESCRICAO = Curso;
            novoCursos.CURSOCODHABILIDADE = Habilidade;
            novoCursos.CURSOMODALIDADE = Modalidade;
            Cursos ultimoCurso = bd.Cursos.ToList().Last();
            int ultimoID = ultimoCurso.CURSOID;
            novoCursos.CURSOID = ultimoID + 1;

            bd.Cursos.Add(novoCursos);
            bd.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DisciplinaPorCurso(int? id)
        {

           return View(bd.Disciplinas.ToList().Where(x => x.CURSOID == id)); 
        }
    }
}