using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC2.Models;

namespace WebMVC2.Repository
{
	public class BaseRepository<T> where T:BaseModel
	{
		private static List<T> list = new List<T>();
		private static int id = 1;

		public virtual void Create(T model)
		{
			model.Id = id;
			id++;
			list.Add(model);
		}
		public virtual List<T> Read()
		{
			return list;
		}
		public virtual T Read(int id)
		{
			return list.Find(p => p.Id == id);
		}
		public virtual void Update(T model)
		{
			int index = list.FindIndex(p => p.Id == model.Id);
			if (index != -1)
			{
				list[index] = model;
			}
		}
		public virtual void Delete(int id)
		{
			T model = Read(id);
			if (model != null)
			{
				list.Remove(model);
			}
		}
	}
}