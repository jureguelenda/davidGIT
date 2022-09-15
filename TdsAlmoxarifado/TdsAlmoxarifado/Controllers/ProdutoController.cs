using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TdsAlmoxarifado.Models;

namespace TdsAlmoxarifado.Controllers
{
    public class ProdutoController : Controller
    {
        BDTdsAlmoxarifado bd = new BDTdsAlmoxarifado ();

        // GET: Produto

        [HttpGet]
        public ActionResult Index()
        {
            return View(bd.PRODUTO.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult Create(string descricao,string minimo,string maximo,string estoque)
        {
            PRODUTO novoPRODUTO = new PRODUTO();
            novoPRODUTO.PRODESCRICAO = descricao;
            novoPRODUTO.PROMINIMO = Convert.ToInt32(minimo);
            novoPRODUTO.PROMAXIMO = Convert.ToInt32(maximo);
            novoPRODUTO.PROESTOQUE = Convert.ToInt32(estoque);

            bd.PRODUTO.Add(novoPRODUTO);
            bd.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            PRODUTO produtoLocalizar = bd.PRODUTO.ToList().Where(x => x.PROID == id).First();
            return View(produtoLocalizar);
        }

        [HttpPost]
        public ActionResult Edit(int? id,string descricao, string minimo, string maximo, string estoque)
        {
            PRODUTO atualizaProduto = bd.PRODUTO.ToList().Where(X => X.PROID == id).First();
            atualizaProduto.PRODESCRICAO = descricao;
            atualizaProduto.PROMINIMO = Convert.ToInt32(minimo);
            atualizaProduto.PROMAXIMO = Convert.ToInt32(maximo);
            atualizaProduto.PROESTOQUE = Convert.ToInt32(estoque);

            bd.Entry(atualizaProduto).State = EntityState.Modified;

            bd.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            PRODUTO excluirProduto = bd.PRODUTO.ToList().Where(x => x.PROID == id).First();

            return View(excluirProduto);
        }

        [HttpPost]
        public ActionResult DeleteConfirma(int? id)
        {
            PRODUTO excluirProduto = bd.PRODUTO.ToList().Where(x => x.PROID == id).First();
            bd.PRODUTO.Remove(excluirProduto);

            try
            {
                bd.SaveChanges();
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            return View();
        }
    }
}