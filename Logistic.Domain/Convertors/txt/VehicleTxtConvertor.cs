using Logistic.Domain.Models;
using System;

namespace Logistic.Domain.Convertors.txt
{
    internal class VehicleTxtConvertor : ITxtConvector<Vehicle>
    {
        private char separator = ',';   
        public Vehicle Convert(string line)
        {
            var vehicleParts = line.Split(separator);
            return new Vehicle
            {
                Name = vehicleParts[0],
                Model = vehicleParts[1],
                Year = System.Convert.ToInt32(vehicleParts[2]),
                Capacity = System.Convert.ToInt32(vehicleParts[3]),
            };
        }

        public string Convert(Vehicle vehilce)
        {
            return $"{vehilce.Name}{separator}{vehilce.Model}{separator}{vehilce.Year}{separator}{vehilce.Capacity}";
        }
    }
}
