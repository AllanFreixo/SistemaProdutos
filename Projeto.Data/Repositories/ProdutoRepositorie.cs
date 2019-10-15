using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using Dapper;
using System.Data.SqlClient;

namespace Projeto.Data.Repositories
{
    public class ProdutoRepositorie : IProdutoRepositories
    {
        private string query;
        private string caminhoBanco;

        public ProdutoRepositorie(string caminhoBanco)
        {
            this.caminhoBanco = caminhoBanco;
        }

        public void Inserir(Produto obj)
        {
            query = "insert  Produto (Nome, Preco, Quantidade, DataCadastro) " +
                   "Values (@Nome, @Preco, @Quantidade, GETDATE())";
            using (SqlConnection connection = new SqlConnection(caminhoBanco))
            {
                connection.Execute(query, obj);
            }
            
        }

        public void Atualizar(Produto obj)
        {
            query = "update Produto set Nome = @Nome, Preco = @Preco, " +
                "Quantidade = @Quantidade";
            using (SqlConnection connection = new SqlConnection(caminhoBanco))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(int id)
        {
            query = "Delete Produto where IdProduto = @IdProduto";
            using (SqlConnection connection = new SqlConnection(caminhoBanco))
            {
                connection.Execute (query, new { IdProduto = id });
            }
        }

        public List<Produto> PesquisarTodos()
        {
            query = "Select * From Produto";
            using (SqlConnection connection = new SqlConnection(caminhoBanco))
            {
              return connection.Query<Produto>(query).ToList();
            }
        }

        public Produto PesquisarPorID(int id)
        {
            query = "Select * from Produto where IdProduto = @IdProduto";
            using (SqlConnection connection = new SqlConnection(caminhoBanco))
            {
                return connection.Query<Produto>(query, new { IdProduto = id }).SingleOrDefault();
            }
        }

        public List<Produto> ObterPorNome(string nome)
        {
            query = " Select * From Produto where  Nome like @Nome";
            using (SqlConnection connection = new SqlConnection(caminhoBanco))
            {
                return connection.Query<Produto>(query, new { Nome = "%" + nome + "%" }).ToList();
            }
        }
    }
}
