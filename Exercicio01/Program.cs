using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio01.Entities;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\n Tax Payer #{0} Data", i);

                Console.Write("Individual or Company (I/C): ");
                char opc = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opc == 'C')
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    payers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                else
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    payers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
            }

            Console.WriteLine("\n TAXES PAID: \n");

            foreach (var p in payers)
            {
                Console.WriteLine(p);
            }
        }
    }
}
