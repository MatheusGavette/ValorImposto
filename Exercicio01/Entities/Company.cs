using System.Globalization;

namespace Exercicio01.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company (string name, double companyIncome, int numberOfEmployees) : base (name, companyIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }

        public override string ToString()
        {
            return Name
                + ": "
                + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
