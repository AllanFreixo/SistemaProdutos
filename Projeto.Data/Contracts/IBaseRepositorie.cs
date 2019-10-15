using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Contracts
{
    public interface IBaseRepositorie <T>
        where T : class
    {
        void Inserir(T obj);
        void Atualizar(T obj);
        void Excluir(int id);
        List<T> PesquisarTodos();
        T PesquisarPorID(int id);
        

    }
}
