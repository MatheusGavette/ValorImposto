using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }
    }
}
