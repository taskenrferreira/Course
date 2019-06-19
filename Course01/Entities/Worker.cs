﻿using Course01.Entities.Enums;
using System.Collections.Generic;

namespace Course01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get ; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
           
        }

        public void RemoveContract(HourContract contract)
        {
            contract.
        }

        public override string ToString()
        {
            return
                $"Name: {Name} \n" +
                $"Income: {}";
        }
    }
}
