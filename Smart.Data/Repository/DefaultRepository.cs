using Microsoft.EntityFrameworkCore;
using Smart.Data.Context;
using Smart.Data.Interface;
using Smart.Data.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Smart.Data.Repository
{
    public class DefaultRepository<T> : IDefaultRepository<T> where T : BaseEntity
    {
        #region Members
        private readonly SmartContext _context;
        private readonly DbSet<T> table;
        #endregion

        #region Ctor
        public DefaultRepository(SmartContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        #endregion

        #region Methods
        public IEnumerable<T> GetAll()
        {
            return table.AsQueryable();
        }

        public T GetById(Guid id)
        {
            return table.AsQueryable().FirstOrDefault(x => x.Id == id);
        }

        public bool Insert(T entity)
        {
            try
            {
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();

                entity.CreateTime = DateTime.Now;
                table.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                entity.UpdateTime = DateTime.Now;
                table.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                table.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
