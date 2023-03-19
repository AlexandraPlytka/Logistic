using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic.Domain.Exceptions
{
    public class ModelStateException:Exception
    {
        public ModelStateException(string message) : base(message) { }
        public override string Message
        {
            get
            {
                return "Model State Error: "+ base.Message;
            }
        }
    }
}
