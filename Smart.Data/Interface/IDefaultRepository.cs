using Smart.Data.Models.Base;
using System;
using System.Collections.Generic;

namespace Smart.Data.Interface
{
    public interface IDefaultRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
