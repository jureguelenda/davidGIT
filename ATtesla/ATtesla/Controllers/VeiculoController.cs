using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ATtesla.Models;

namespace ATtesla.Controllers
{
    public class VeiculoController : Controller
    {
        private carrosTeslaEntities db = new carrosTeslaEntities();

        // GET: Veiculo
        public ActionResult Index()
        {
            return View(db.Veiculo.ToList());
        }

        // GET: Veiculo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculo.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // GET: Veiculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculo/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO,DESCRICAO,VALOR,CODIGMODELO")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                db.Veiculo.Add(veiculo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veiculo);
        }

        // GET: Veiculo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculo.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculo/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO,DESCRICAO,VALOR,CODIGMODELO")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(veiculo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        // GET: Veiculo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = db.Veiculo.Find(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Veiculo veiculo = db.Veiculo.Find(id);
            db.Veiculo.Remove(veiculo);
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
