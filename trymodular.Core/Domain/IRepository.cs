using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trymodular.Core.Domain.Models;

namespace trymodular.Core.Domain {
    public interface IRepository<T> : IRepository<T, long> where T : IEntity<long> {
    }

    public interface IRepository<T, in TId> where T : IEntity<TId> {
        IQueryable<T> Query();

        void Add(T entity);

        void Remove(T entity);

        void SaveChange();
    }
}
