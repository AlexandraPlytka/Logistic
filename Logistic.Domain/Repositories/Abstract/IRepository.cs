using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic.Domain.Repositories.Abstract
{
    public interface IRepository<T>
    {
        void Add(T item);
        T[] GetAll();
        int Count();

    }
}
