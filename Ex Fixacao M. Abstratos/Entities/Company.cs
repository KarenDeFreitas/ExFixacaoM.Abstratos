namespace Ex_Fixacao_M._Abstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }


        public override double Tax()
        {
            double tax = 0;


            if (NumberOfEmployees < 10)
            {
                tax = AnualIncome * 0.16;
            }


            else
            {
                tax = AnualIncome * 0.14;
            }


            return tax;
        }
    }
}
