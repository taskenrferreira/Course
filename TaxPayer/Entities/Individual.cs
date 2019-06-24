namespace TaxPayers.Entities
{
    class Individual: TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double annualIncome)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if (AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15 - HealthExpenditures * 0.50);
            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenditures * 0.50);
            }
        }
    }
}
