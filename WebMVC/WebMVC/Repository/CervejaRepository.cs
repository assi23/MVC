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
		public Cerveja Listar(int id) 
		{
			return listaCerveja.Find(c => c.Id == id);
		}

		public void Editar(Cerveja model) 
		{
			int index = listaCerveja.FindIndex(c => c.Id == model.Id);
			listaCerveja[index] = model;
		}
		public void Deletar(int id) 
		{
			Cerveja model = Listar(id);
			if (model != null) 
			{
				listaCerveja.Remove(model);
			}

		}
	}
}