using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    public interface IRepositorioBase<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(int id);
    }
}