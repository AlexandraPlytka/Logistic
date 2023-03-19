using Logistic.Domain.Enums;
using Logistic.Domain.Factories.Abstract;
using Logistic.Domain.Factories.Concreate;
using Logistic.Domain.Factories.Mock;
using System;

namespace Logistic.Domain.Factories
{
    public class FactoryProvider
    {
        private FactoryType type;
        public FactoryProvider(FactoryType type)
        {
                this.type = type;   
        }
        public IRepositoriesFactory GetRepositoryFactory()
        {
            if (type == FactoryType.Memory)
                return new MemoryRepositoryFactory();
            else if (type == FactoryType.Mock)
                return new MockRepositoryFactory();
            else
                throw new Exception("Wrong factory type");
        }
    }
}
