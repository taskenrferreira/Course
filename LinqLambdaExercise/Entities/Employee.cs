using System.Globalization;

namespace LinqLambdaExercise.Entities {
    class Employee {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] vect = csvEmployee.Split(',');

            Name = vect[0];
            Email = vect[1];
            Salary = double.Parse(vect[2], CultureInfo.InvariantCulture);
        }

        public override string ToString() {
            return Name
                + ", "
                + Email
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);                
        }
    }
}
