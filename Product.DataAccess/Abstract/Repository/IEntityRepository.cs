﻿
using Product.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Abstract.Repository
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(Expression<Func<T, bool>> filter);
    }
}