using System;
using System.Collections.Generic;

namespace ExercicioFixacao199CSharpNelioAlves.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            //adicionado após visualizar a versão do prof Nelio Alves
            //https://github.com/acenelio/interfaces4-csharp/blob/master/Course/Entities/Contract.cs
            Installments = new List<Installment>();
        }

        //adicionado após visualizar a versão do prof Nelio Alves
        //https://github.com/acenelio/interfaces4-csharp/blob/master/Course/Entities/Contract.cs
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
