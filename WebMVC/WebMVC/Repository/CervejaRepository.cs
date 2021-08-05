using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC.Models;

namespace WebMVC.Repository
{
	public class CervejaRepository
	{
		public static List<Cerveja> listaCerveja = new List<Cerveja>();

		public void Salvar(Cerveja model)
		{
			listaCerveja.Add(model);
		}
		public List<Cerveja> Listar() 
		{
			return listaCerveja;
		}
	}
}