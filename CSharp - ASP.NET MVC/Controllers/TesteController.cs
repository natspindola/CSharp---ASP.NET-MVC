using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharp___ASP.NET_MVC.Models;

namespace CSharp___ASP.NET_MVC.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            ViewBag.PessoaInformada = pessoa;
            return View("Saudacao", pessoa);
        }
    }
}