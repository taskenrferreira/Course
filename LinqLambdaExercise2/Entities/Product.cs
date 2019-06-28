using System.Globalization;

namespace LinqLambdaExercise2.Entities {
    class Product {
        public string Name { get; set; }        
        public double Price { get; set; }

        public Product(string csvProduct) {
            string[] vect = csvProduct.Split(',');

            Name = vect[0];
            Price = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString() {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
