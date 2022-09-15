using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TdsAlmoxarifado.Models;

namespace TdsAlmoxarifado.Controllers
{
    public class AreaController : Controller
    {
        BDTdsAlmoxarifado bd = new BDTdsAlmoxarifado();

        // GET: Area

        [HttpGet]
        public ActionResult Index()
        {
            //var dados = bd.AREA.ToList();
            return View(bd.AREA.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string descricao)
        {
            AREA novoArea = new AREA();
            novoArea.ARESDESCRICAO = descricao;
            bd.AREA.Add(novoArea);

            try
            {
                bd.SaveChanges();
            }
            catch(Exception)
            {
                return RedirectToAction("erroBD", "Home");
            }
            

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            AREA exibirArea = bd.AREA.ToList().Where(y => y.AREID == id).First();
            return View(exibirArea);
        }

        [HttpPost]

        public ActionResult Edit(int id, string descricao)
        {
            AREA updateArea = bd.AREA.ToList().Where(y => y.AREID == id).First();
            updateArea.ARESDESCRICAO = descricao;
            bd.Entry(updateArea).State = EntityState.Modified;
            try
            {
                bd.SaveChanges();
            }
            catch(Exception)
            {
                return RedirectToAction("erroBD", "Home");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            AREA exibirArea = bd.AREA.ToList().Where(y => y.AREID == id).First();
            return View(exibirArea);
        }

        [HttpPost]

        public ActionResult ExcluirConfirmar(int id)
        {
            AREA excluirArea = bd.AREA.ToList().Where(y => y.AREID == id).First();
            bd.AREA.Remove(excluirArea);

            try
            {
                bd.SaveChanges();
            }
            catch (Exception)
            {
                Mensagem.textoErro = "NÃO É POSSIVEL EXCLUIR UMA ÁREA JA RELACIONADA A UM COLABORADOR";
                return RedirectToAction("erroBD", "Home");
            }
            return RedirectToAction("Index");
        }
    }
}
