using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wfe.Data
{
    public interface IQuery<T, TU>
    {
        TU Run(T @params);
    }

    public class FindById
    {
        public long Id { get; set; }
    }

    public class FindByName
    {
        public long Name { get; set; }
    }
}