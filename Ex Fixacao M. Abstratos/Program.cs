using System;
using System.Collections.Generic;
using Ex_Fixacao_M._Abstratos.Entities;

namespace Ex_Fixacao_M._Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();


            Console.Write("Qual o número de contribuintes? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Dados do contribuinte #" + i + ": ");
                
                Console.Write("Pessoa Física ou Jurídica? (f/j) ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Renda Anual: R$");
                double anualIncome = double.Parse(Console.ReadLine());


                if (type == 'f')
                {
                    Console.Write("Despesas médicas: R$");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(healthExpenditures, name, anualIncome));
                }


                else
                {
                    Console.Write("Número de funcionários: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(numberOfEmployees, name, anualIncome));
                }

            }

            Console.WriteLine();


            double sum = 0;

            foreach (TaxPayer taxPayer in taxPayers)
            {
                sum += taxPayer.Tax();

                Console.WriteLine(taxPayer.Name + 
                    ": R$" + 
                    taxPayer.Tax().ToString("F2"));
            }

            Console.WriteLine();
            Console.WriteLine("Total das taxas: R$" + 
                sum.ToString("F2"));

        }
    }
}
