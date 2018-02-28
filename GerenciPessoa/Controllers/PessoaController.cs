using GerenciPessoa.Business;
using GerenciPessoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciPessoa.Controllers
{
	public class PessoaController : Controller
	{
		// GET: Pessoa
		public ActionResult Index()
		{
			PessoaBusiness business = new PessoaBusiness();
			List<Pessoa> pessoas = business.GetAll();

			List<PessoaModel> pessoaModel = new List<PessoaModel>();

			foreach (Pessoa pessoa in pessoas)

				pessoaModel.Add(new PessoaModel()
				{
					id = pessoa.Id,
					nome = pessoa.Nome,
					sobrenome = pessoa.SobreNome,
					dataaniversario = pessoa.DataAniversario
				});
			return View(pessoaModel);
		}

		// GET: Pessoa/Details/5
		public ActionResult Details(int id)
		{
			PessoaModel pessoaModel = GeneratePessoaModel(id);

			return View(pessoaModel);
		}


		// GET: Pessoa/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Pessoa/Create
		[HttpPost]
		public ActionResult Create(PessoaModel pessoa)
		{
			List<Pessoa> Pessoa = new List<Pessoa>();
			if (ModelState.IsValid)
			{
				var repository = new PessoaBusiness();
				int i = repository.FindById(Pessoa);
				i++;
				repository.Add(new Pessoa()
				{
					Id = i,
					Nome = pessoa.nome,
					SobreNome = pessoa.sobrenome,
					DataAniversario = pessoa.dataaniversario,
				});
				return RedirectToAction("Index");
			}
			return View(pessoa);
		}
		// GET: Pessoa/Edit/5
		public ActionResult Edit(int id)
		{
			PessoaModel pessoaModel = GeneratePessoaModel(id);

			return View(pessoaModel);
		}

		// POST: Pessoa/Edit/5
		[HttpPost]
		public ActionResult Edit(PessoaModel nova)
		{
			try
			{
				PessoaBusiness business = new PessoaBusiness();

				Pessoa pessoa = new Pessoa()
				{
					Id = nova.id,
					Nome = nova.nome,
					SobreNome = nova.sobrenome,
					DataAniversario = nova.dataaniversario,
				};

				business.Update(pessoa);

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Pessoa/Delete/5
		public ActionResult Delete(int id)
		{
			PessoaModel pessoaModel = GeneratePessoaModel(id);

			return View(pessoaModel);

		}

		// POST: Pessoa/Delete/5
		[HttpPost]
		public ActionResult Delete(PessoaModel pessoa)
		{
			try
			{
				PessoaBusiness business = new PessoaBusiness();
				business.Delete(pessoa.id);

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
		//GET: Pessoa/Generate
		private static PessoaModel GeneratePessoaModel(int id)
		{
			PessoaBusiness pBusinessGenerate = new PessoaBusiness();
			Pessoa pessoa = pBusinessGenerate.FindById(id);

			PessoaModel pessoaModel = new PessoaModel()
			{
				id = pessoa.Id,
				nome = pessoa.Nome,
				sobrenome = pessoa.SobreNome,
				dataaniversario = pessoa.DataAniversario,
			};
			return pessoaModel;
		}
		//// GET: Pessoa/Pesquisa
		//public ActionResult Pesquisa()
		//{
		//	return View();
		//}

		//// POST: Pessoa/Pesquisa
		//[HttpPost]
		//public ActionResult Pesquisa(string pessoaproc)
		//{
		//	PessoaBusiness pBusinessPesquisa = new PessoaBusiness();
		//	Pessoa pessoa = pBusinessPesquisa.FindByName(pessoaproc);

		//	PessoaModel pessoaViewModel = new PessoaModel()
		//	{
		//		id = pessoa.Id,
		//		nome = pessoa.Nome,
		//		sobrenome = pessoa.SobreNome,
		//		dataaniversario = pessoa.DataAniversario,
		//	};
		//	return pessoaModel;

		//}

	}
}