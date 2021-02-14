using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.Access
{
    // generic constraint : kısıt
    // class : referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        // generic constraint : kısıt
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
