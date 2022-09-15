using BDFunil.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BDFunil.Controllers
{
    public class VagasController : Controller
    {
        BDFunilEntities bd = new BDFunilEntities();

        // GET: Vagas
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.qtdVagas = bd.VAGA.ToList().Count();
            return View(bd.VAGA.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int id,string nome, string descricao,string atribuicao,decimal salario, string requisito, string data)
        {
            VAGA novaVaga = new VAGA();
            novaVaga.VAIID = Convert.ToInt32(id);
            novaVaga.VAINOME = nome;
            novaVaga.VAIDESCRICAO = descricao;
            novaVaga.VAIATRIBUICAO = atribuicao;
            novaVaga.VAISALARIO =  salario;
            novaVaga.VAIREQUISITO = requisito;
            novaVaga.VAIDATACADASTRO = Convert.ToDateTime(data);

            bd.VAGA.Add(novaVaga);
            bd.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            VAGA localizarVaga = bd.VAGA.ToList().Where(x => x.VAIID == id).First();
            return View(localizarVaga);
        }

        [HttpPost]
        public ActionResult Editar(int id, string nome, string descricao, string atribuicao, int salario, string requisito, string data)
        {
            VAGA atualizarVaga =bd.VAGA.ToList().Where(x => x.VAIID == id).First();
            atualizarVaga.VAIID = Convert.ToInt32(id);
            atualizarVaga.VAINOME = nome;
            atualizarVaga.VAIDESCRICAO = descricao;
            atualizarVaga.VAIATRIBUICAO = atribuicao;
            atualizarVaga.VAISALARIO = Convert.ToInt32(salario);
            atualizarVaga.VAIREQUISITO = requisito;
            atualizarVaga.VAIDATACADASTRO = Convert.ToDateTime(data);

            bd.Entry(atualizarVaga).State= EntityState.Modified;
            bd.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Excluir(int? id)
        {
            VAGA excluirProduto = bd.VAGA.ToList().Where(x => x.VAIID == id).First();

            return View(excluirProduto);
        }

        [HttpPost]
        public ActionResult ExcluirConfirma(int? id)
        {
            VAGA excluirProduto = bd.VAGA.ToList().Where(x => x.VAIID == id).First();
            bd.VAGA.Remove(excluirProduto);

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

        [HttpPost]
        public ActionResult Candidatos()
        {
            ViewBag.qtdCandidatos = bd.CANDIDATOVAGA.ToList().Count();
            return View(bd.VAGA.ToList());
        }
    }    
}