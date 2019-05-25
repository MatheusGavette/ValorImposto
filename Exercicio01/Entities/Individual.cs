using System.Globalization;

namespace Exercicio01.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual (string name, double individualIncome, double healthExpenditures) : base (name, individualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome <= 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
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
