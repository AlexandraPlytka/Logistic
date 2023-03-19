﻿using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;
using System;

namespace Logistic.Domain.Repositories.Concreate
{
    internal class MonkTruckRepository : ITruckRepository
    {
        private Truck[] trucks;
        int count;
        public MonkTruckRepository()
        {
            trucks= new Truck[100];
            count = 0; 
        }
        public void Add(Truck truck)
        {
            trucks[count++] = truck;       
        }

        public int Count() => count;

        public Truck[] GetAll() => trucks;
    }
}