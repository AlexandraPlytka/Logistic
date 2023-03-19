using System;

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
