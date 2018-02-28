using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GerenciPessoa.Models
{
	public class PessoaModel
	{
		[Key]
		public int id { get; set; }

		[Required(ErrorMessage = "O campo Nome é obrigatório")]
		[StringLength(20)]
		public string nome { get; set; }

		[Required(ErrorMessage = "O campo SobreNome é obrigatório")]
		[StringLength(20)]
		public string sobrenome { get; set; }

		[Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
		[StringLength(20)]
		[MinLength(0, ErrorMessage = "Please supply a year of collection")]
		[RegularExpression("^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$")]
		public string dataaniversario { get; set; }
	}
}