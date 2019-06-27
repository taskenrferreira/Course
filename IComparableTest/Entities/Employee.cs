using System;
using System.Globalization;

namespace IComparableTest.Entities {
    class Employee /*: IComparable*/ {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmloyee) {
            string[] vect = csvEmloyee.Split(',');

            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString() {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);               
        }

        //public int CompareTo(object obj) {
        //    if (!(obj is Employee)) {
        //        throw new ArgumentException("Comparing error: argument is not an Employee");
        //    } else {
        //        Employee other = obj as Employee;
        //        return Name.CompareTo(other.Name);
        //    }           
        //}
    }
}
