using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Presentation.Models;
using Projeto.Data.Entities;
using Projeto.Data.Contracts;

namespace Projeto.Presentation.Controllers
{
    public class ProdutoController : Controller
    {
        //atributo
        private IProdutoRepositories repositories;

        public ProdutoController(IProdutoRepositories repositories)
        {
            this.repositories = repositories;
        }

        #region Cadastro
        public IActionResult Cadastro()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;

                    repositories.Inserir(produto);

                    TempData["Mensagem"] = $"Produto {produto.Nome} cadastrado com sucesso";
                    ModelState.Clear();


                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }
            return View();
        }

       
        #endregion
        
        #region Consulta
        public IActionResult Consulta()
        {
            List<ProdutoConsultaModel> lista = new List<ProdutoConsultaModel>();
            try
            {
                foreach (var item in repositories.PesquisarTodos())
                {

                    ProdutoConsultaModel model = new ProdutoConsultaModel();
                    model.IdProduto = item.IdProduto;
                    model.Nome = item.Nome;
                    model.Preco = item.Preco;
                    model.Quantidade = item.Quantidade;
                    model.Total = item.Preco * item.Quantidade;
                    model.DataCadastro = item.DataCadastro;
                    lista.Add(model);

                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }
            return View(lista);
        }
        #endregion

        #region Exclusao
        public IActionResult Exclusao(int id)
        {
            try
            {
                repositories.Excluir(id);
                TempData["Mensagem"] = "Produto Excluido com Sucesso";
            }
            catch (Exception e)
            {

                TempData["Mensagem"] = e.Message;
            }

            return RedirectToAction("Consulta");
        }
        #endregion

        #region Atualizar
        public IActionResult Edicao(int id)
        {
            ProdutoEdicaoModel model = new ProdutoEdicaoModel();
            Produto produto = repositories.PesquisarPorID(id);

            try
            {
                model.IdProduto = produto.IdProduto;
                model.Nome = produto.Nome;
                model.Preco = produto.Preco;
                model.Quantidade = produto.Quantidade;
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return View(model);
        }


        [HttpPost]
        public IActionResult Edicao(ProdutoEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    produto.IdProduto = model.IdProduto; 
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;

                    repositories.Atualizar(produto);

                    TempData["Mensagem"] = $"Produto {produto.Nome} cadastrado com sucesso";
                    return RedirectToAction("Consulta");


                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }
            return View();
        }
        #endregion

    }
}