using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using CadastroProdutos.Models;
using System.Web.Mvc;

namespace CadastroProdutos.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            var produto = new Produtos();
            return View(produto);
        }
        [HttpPost]
        public ActionResult Index(Produtos produto)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", produto);
            }
            return View(produto);
        }

        public ActionResult Resultado(Produtos produto)
        {
            return View(produto);
        }
    }
}