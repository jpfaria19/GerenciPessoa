using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciPessoa.Models
{
	public class Pessoa
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string SobreNome { get; set; }
		public string DataAniversario { get; set; }
	}
}