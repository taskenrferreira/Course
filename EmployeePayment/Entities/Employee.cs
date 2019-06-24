using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayment.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("PAYMENTS:");
        //    sb.Append(Name);
        //    sb.Append(" - $ ");
        //    sb.Append(Payment());

        //    return sb.ToString();
        //}
    }
}
