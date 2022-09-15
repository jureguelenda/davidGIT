using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Escola.Controllers
{
    public class DisciplinasController : Controller
    {
        // GET: Disciplinas
        public ActionResult Index()
        {
            return View();
        }
    }
}