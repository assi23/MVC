using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVC2.Models
{
	public class Produto : BaseModel
	{
		public string Nome{ get; set; }
		[Display(Name = "Descrição")]
		public string Desc { get; set; }
	}
}