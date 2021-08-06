using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
	public class Cerveja
	{

		public int Id { get; set; }
		public string Marca { get; set; }
		public string Tipo { get; set; }
		public string Distribuidora { get; set; }
	}
}