using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using WebMVC.Repository;

namespace WebMVC.Controllers
{
	public class HomeController : Controller
	{
		CervejaRepository repository = new CervejaRepository();
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Cadastrar()
		{
			return View();
		}
		public ActionResult Salvar(Cerveja model) 
		{
			repository.Salvar(model);
			return View();
		}
		public ActionResult Listar() 
		{
			List<Cerveja> model = repository.Listar();
			//é apresentado em listar
			return View(model);
		}

	}
}