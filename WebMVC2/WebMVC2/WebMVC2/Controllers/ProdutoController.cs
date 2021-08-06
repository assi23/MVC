using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC2.Models;
using WebMVC2.Repository;

namespace WebMVC2.Controllers
{
    public class ProdutoController : Controller
    {
        ProdutoRepository repository = new ProdutoRepository();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Cadastrar() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Produto model)
        {
            repository.Create(model);
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            Produto model = repository.Read(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(Produto model)
        {
            repository.Update(model);
            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
            return View(repository.Read());
        }
        public ActionResult Details(int id) 
        {
            return View(repository.Read(id));
        }
        public ActionResult Delete(int id) 
        {
            repository.Delete(id);
            return RedirectToAction("Listar");
        }
        public ActionResult DeletePage(int id)
        {
            return View(repository.Read(id));
        }
    }
}