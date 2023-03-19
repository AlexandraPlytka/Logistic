using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic.Domain.Repositories.Mock
{
    public class MockDriverRepository : IDriverRepository
    {
        private Driver[] drivers;
        int count;
        public MockDriverRepository()
        {
            drivers = new Driver[]
            {
                new Driver{Id = "001", Name = "David", Experience = 2},
                new Driver{Id = "002", Name = "Stephen", Experience = 9},
                new Driver{Id = "003", Name = "Mark", Experience =5},
                new Driver{Id = "004", Name = "Serhiy", Experience =1}
            };
             count = 4;
        }
        public void Add(Driver driver)
        {
          //  drivers[count++] = driver;
        }

        public int Count() => count;

        public Driver[] GetAll() => drivers;
        
    }
}
