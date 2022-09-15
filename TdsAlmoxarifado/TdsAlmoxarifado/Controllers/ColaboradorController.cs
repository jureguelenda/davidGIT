using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TdsAlmoxarifado.Models;

namespace TdsAlmoxarifado.Controllers
{
    public class ColaboradorController : Controller
    {
        BDTdsAlmoxarifado bd = new BDTdsAlmoxarifado();

        // GET: Colaborador
        public ActionResult Index()
        {
            return View(bd.COLABORADOR.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.listaArea = bd.AREA.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(string nome, string cargo, int area)
        {
            COLABORADOR colaborador = new COLABORADOR();
            colaborador.COLNOME = nome;
            colaborador.COLCARGO = cargo;
            colaborador.AREID = area;

            try
            {
                bd.COLABORADOR.Add(colaborador);
                bd.SaveChanges();
            }
            catch
            {
                return RedirectToAction("erroBD", "Home");
            }

            return RedirectToAction("Index");
        }
    }
}