using GerenciPessoa.DataAccess;
using GerenciPessoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciPessoa.Business
{
	public class PessoaBusiness
	{
		public List<Pessoa> GetAll()
		{
			PessoaDA pessoaDA = new PessoaDA();

			List<Pessoa> lista = pessoaDA.GetAll();

			return lista;
		}

		public Pessoa FindById(int id)
		{
			PessoaDA pessoaDA = new PessoaDA();

			Pessoa pessoaId = pessoaDA.FindById(id);

			return pessoaId;
		}

		public int FindById(List<Pessoa> list)
		{
			//Retirado do site
			int maxId = 0;
			//if (list.Count == 0)
			//{
			//	//throw new InvalidOperationException("A Lista está vazia");
			//	maxId = 0;
			//}

			//foreach (Pessoa item in list )
			//{
			////	if (item.Id > maxId)
			////	{
			//		maxId = item.Id;
			////	}
			//}
			maxId = list.Count;

			//PessoaDA pessoaDA = new PessoaDA();

			//Pessoa pessoaId = pessoaDA.FindById(list);

			return maxId;
		}

		public void Add(Pessoa novaPessoa)
		{
			PessoaDA pessoaDA = new PessoaDA();

			pessoaDA.Add(novaPessoa);
		}

		internal void Update(Pessoa pessoa)
		{
			PessoaDA pessoaDA = new PessoaDA();

			pessoaDA.Update(pessoa);

		}

		internal void Delete(int id)
		{
			PessoaDA pessoaDA = new PessoaDA();

			pessoaDA.Delete(id);
		}

		internal Pessoa FindByName(string proc)
		{
			PessoaDA pessoaDA = new PessoaDA();

			pessoaDA.FindByName(proc);

			Pessoa pesquisaName = pessoaDA.FindByName(proc);

			return pesquisaName;
		}
	}
}