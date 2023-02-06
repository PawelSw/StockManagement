using StockManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace StockManagement.DataAccess
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task Insert(T entity);

        Task Update(T entity);

        Task Delete(int id);
    }
}
