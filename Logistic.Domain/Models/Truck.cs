using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Logistic.Domain.Models
{
    public class Truck
    {
        public string name;
        public string model;
        public int capacity;
        public int year;
        public int length;
        public string Name { get; set; }
        public string Model { get; set; }
        public int? Capacity { get; set; }
        public int? Year { get; set; }  
        public int Length { get; set;}
        public override string ToString() => $"{Name} - {Model} - {Year} - {Capacity} - {Length}";

    }
}
