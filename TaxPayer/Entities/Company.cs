namespace TaxPayers.Entities
{
    class Company : TaxPayer
    {
        public int Employees { get; set; }

        public Company(int employees, string name, double annualIncome)
            : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double TaxesPaid()
        {
            if (Employees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
