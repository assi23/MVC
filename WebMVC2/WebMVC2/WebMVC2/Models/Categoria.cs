using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC2.Models
{
	public class Categoria : BaseModel
	{
		public string Tipo { get; set; }
		public string Setor { get; set; }
	}
}