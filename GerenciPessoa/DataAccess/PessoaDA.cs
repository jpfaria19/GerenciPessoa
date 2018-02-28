using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GerenciPessoa.Models;

namespace GerenciPessoa.DataAccess
{
	public class PessoaDA
	{
		static List<Pessoa> ListaPessoa = new List<Pessoa>();


		public List<Pessoa> GetAll()
		{
			List<Pessoa> listaAll = new List<Pessoa>();
			for (int i = 0; i < ListaPessoa.Count; i++)
			{
				Pessoa p = new Pessoa();
				p.Id = ListaPessoa[i].Id;
				p.Nome = ListaPessoa[i].Nome;
				p.SobreNome = ListaPessoa[i].SobreNome;
				p.DataAniversario = ListaPessoa[i].DataAniversario;
				listaAll.Add(p);
			}

			return listaAll;
		}

		public Pessoa FindById(int id)
		{
			Pessoa pessoa = new Pessoa();
			int index = ListaPessoa.FindIndex(x => x.Id == id);//id - 1;

			pessoa = new Pessoa();
			pessoa.Id = ListaPessoa[index].Id;
			pessoa.Nome = ListaPessoa[index].Nome;
			pessoa.SobreNome = ListaPessoa[index].SobreNome;
			pessoa.DataAniversario = ListaPessoa[index].DataAniversario;

			//HttpContext.Current.Response.Write("Index não passa do id = 0");

			return pessoa;
		}

		internal Pessoa FindByName(string nome)
		{
			int index = ListaPessoa.FindIndex(x => x.Nome.Contains(nome));
			return ListaPessoa[index];
		}

		internal void Delete(int id)
		{
			int index = ListaPessoa.FindIndex(x => x.Id == id);
			ListaPessoa.Remove(ListaPessoa[index]);
		}

		internal void Update(Pessoa pessoa)
		{
			int index = ListaPessoa.FindIndex(x => x.Id == pessoa.Id);

			ListaPessoa[index].Nome = pessoa.Nome;
			ListaPessoa[index].SobreNome = pessoa.SobreNome;
			ListaPessoa[index].DataAniversario = pessoa.DataAniversario;

		}

		public void Add(Pessoa nova)
		{
			ListaPessoa.Add(nova);
		}
	}
}