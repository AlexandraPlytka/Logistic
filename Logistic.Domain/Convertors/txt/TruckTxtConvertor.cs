using Logistic.Domain.Models;
using System;

namespace Logistic.Domain.Convertors.txt
{
    internal class TruckTxtConvertor : ITxtConvector<Truck>
    {
        private char separator = ',';   
        public Truck Convert(string line)
        {
            var truckParts = line.Split(separator);
            return new Truck
            {
                Name = truckParts[0],
                Model = truckParts[1],
                Year = System.Convert.ToInt32(truckParts[2]),
                Capacity = System.Convert.ToInt32(truckParts[3]),
                Length = System.Convert.ToInt32(truckParts[4])
            };
        }

        public string Convert(Truck truck)
        {
            return $"{truck.Name}{separator}{truck.Model}{separator}{truck.Year}{separator}{truck.Capacity}";
        }
    }
}
