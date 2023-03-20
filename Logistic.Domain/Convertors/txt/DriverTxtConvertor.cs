using Logistic.Domain.Models;
using System;

namespace Logistic.Domain.Convertors.txt
{
    internal class DriverTxtConvertor : ITxtConvector<Driver>
    {
        private char separator = ',';   
        public Driver Convert(string line)
        {
            var driverParts = line.Split(separator);
            return new Driver
            {
                Name = driverParts[0],
                Id = driverParts[1],
                Experience = System.Convert.ToInt32(driverParts[2]),
            };
        }

        public string Convert(Driver driver)
        {
            return $"{driver.Name}{separator}{driver.Id}{separator}{driver.Experience}";
        }
    }
}
