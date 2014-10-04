using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Core
{
    public interface IRepository<T>
    {
        T FindById(long id);
        IQueryable<T> Find(Func<bool> func);
        void Save(T data);
    }
}
