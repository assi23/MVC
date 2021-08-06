using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC2.Models;

namespace WebMVC2.Repository
{
	public class ProdutoRepository
	{
		private static List<Produto> listaProduto = new List<Produto>();
		private static int id = 1;
		public void Create(Produto model) 
		{
			model.Id = id;
			id++;
			listaProduto.Add(model);
		}
		public List<Produto> Read()
		{
			return listaProduto;
		}
		public Produto Read(int id) 
		{
			return listaProduto.Find(p => p.Id == id);
		}
		public void Update(Produto model)
		{
			int index = listaProduto.FindIndex(p => p.Id == model.Id);
			if (index != -1) 
			{
				listaProduto[index] = model;
			}
		}
		public void Delete(int id)
		{
			Produto model = Read(id);
			if (model != null)
			{
				listaProduto.Remove(model);
			}
		}
	}
}