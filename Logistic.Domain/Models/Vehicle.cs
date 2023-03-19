using System;

namespace Logistic.Domain.Models
{
    public class Vehicle
    {
        private string name;
        private string model;
        private int year;
        private int capacity;
        public string Name{ get; set; }
        public string Model { get; set; }
        public int Year
        {
            get { return year; } set
            {
                if (value < 0)
                    throw ModelStateException("Year is negative");
                year = value;
            }
        }

        private Exception ModelStateException(string v)
        {
            throw new NotImplementedException();
        }

        public int? Capacity { get; set; }
        public override string ToString() => $"{Name} - {Model} - {Year} - {Capacity}";

    }
}
