using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC2.Models;
using WebMVC2.Repository;

namespace WebMVC2.Controllers
{
    public class ProdutoController : BaseController<Produto,ProdutoRepository>
    {
		public ProdutoController():base(new ProdutoRepository())
		{

		}
    }
}