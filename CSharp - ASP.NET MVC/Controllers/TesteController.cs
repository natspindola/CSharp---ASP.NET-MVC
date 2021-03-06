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
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Exclude = "Ativo")]Pessoa pessoa)
        {
            if (ModelState.IsValid) 
            {
                ViewBag.PessoaInformada = pessoa;
                return View("Saudacao", pessoa);
            }
            else
            {
                return View(pessoa);
            }
        }
    }
}