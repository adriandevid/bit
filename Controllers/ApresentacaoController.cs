using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Mvc;

namespace BitSimulator10.Controllers
{
    public class ApresentacaoController : Controller
    {
        // GET: Apresentacao
        public ActionResult IndexApresentacao()
        {
            return View();
        }
         public ActionResult IndexInstrucao()
        {
            return View();
        }
        public ActionResult IndexSobre()
        {
            return View();
        }
        public ActionResult IndexComando()
        {
            return View();
        }
    }
}