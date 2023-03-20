using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic.Domain.Convertors.txt
{
    internal interface ITxtConvector<T>
    {
        T Convert(string line);
        string Convert(T value);
    }
}
