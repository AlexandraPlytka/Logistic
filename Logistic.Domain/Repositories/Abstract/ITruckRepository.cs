using Logistic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic.Domain.Repositories.Abstract
{
    public interface ITruckRepository
    {
        void Add(Truck truck);
        Truck[] GetAll();
        int Count();
    }
}
