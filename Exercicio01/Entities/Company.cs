namespace Exercicio01.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company (string name, double individualIncome, int numberOfEmployees) : base (name, individualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            throw new System.NotImplementedException();
        }
    }
}
