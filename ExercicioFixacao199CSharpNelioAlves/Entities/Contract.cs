using System;


namespace ExercicioFixacao199CSharpNelioAlves.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public Installment Installment { get; set; }
        public Contract(int number, DateTime date, double totalValue, Installment installment)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installment = installment;
        }
    }
}
