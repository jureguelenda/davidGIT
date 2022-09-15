using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baseProfessor;

namespace baseProfessor.Controllers
{
    public class DisciplinaController : Controller
    {
        private atCursoEntities db = new atCursoEntities();

        // GET: Disciplina
        public ActionResult Index()
        {
            var disciplina = db.Disciplina.Include(d => d.Curso);
            return View(disciplina.ToList());
        }

        // GET: Disciplina/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplina.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // GET: Disciplina/Create
        public ActionResult Create()
        {
            ViewBag.CURSOID = new SelectList(db.Curso, "CURSOID", "CURSODESCRICAO");
            return View();
        }

        // POST: Disciplina/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DISID,DISDESCRIACAO,CURSOID,DISCH")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                db.Disciplina.Add(disciplina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CURSOID = new SelectList(db.Curso, "CURSOID", "CURSODESCRICAO", disciplina.CURSOID);
            return View(disciplina);
        }

        // GET: Disciplina/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplina.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            ViewBag.CURSOID = new SelectList(db.Curso, "CURSOID", "CURSODESCRICAO", disciplina.CURSOID);
            return View(disciplina);
        }

        // POST: Disciplina/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DISID,DISDESCRIACAO,CURSOID,DISCH")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
               // db.Entry(disciplina).State = EntityState.Modified; kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CURSOID = new SelectList(db.Curso, "CURSOID", "CURSODESCRICAO", disciplina.CURSOID);
            return View(disciplina);
        }

        // GET: Disciplina/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplina.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // POST: Disciplina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Disciplina disciplina = db.Disciplina.Find(id);
            db.Disciplina.Remove(disciplina);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
