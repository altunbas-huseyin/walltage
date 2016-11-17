﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Walltage.Domain
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Table();
        T FindById(int id);

        void Insert(T entity);
        void BulkInsert(IEnumerable<T> entities);
        void Update(T entity);
        void BulkUpdate(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(int id);
        void BulkDelete(IEnumerable<T> entities);
        void BulkDelete(IEnumerable<object> ids);

        int Count(Expression<Func<T, bool>> match);

        void Save(bool async = false);
    }
}
